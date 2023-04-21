using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateChangedFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This method is called when the form is loaded
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                // Read configuration from appsettings.json file
                var config = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json").Build();
                var section = config.GetSection(nameof(DefaultConfig));
                var defaultConfig = section.Get<DefaultConfig>();

                // Set values of text boxes on the form
                sourceFolderTxt.Text = defaultConfig.SourceFolder;
                destFolderTxt.Text = defaultConfig.DestinationFolder;
                sourceBranchTxt.Text = string.IsNullOrWhiteSpace(defaultConfig.SourceBranch) ? "master" : defaultConfig.SourceBranch;
                ChoosenBranchTxt.Text = string.IsNullOrWhiteSpace(defaultConfig.ChoosenBranch) ? GetCurrentBranch(defaultConfig.SourceFolder) : defaultConfig.ChoosenBranch;
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            base.OnLoad(e);
        }

        // This method returns the current branch of the git repository located at gitFolderPath
        private string GetCurrentBranch(string gitFolderPath)
        {
            // Create a new process to run a command
            var process = new Process();
            process.StartInfo.WorkingDirectory = gitFolderPath;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c git branch --show-current";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            // Read the output of the command
            var cmdOutput = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            // Return the trimmed output
            return cmdOutput.Trim();
        }



        private void CopyChangedFilesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from text boxes on the form
                string sourceFolder = sourceFolderTxt.Text.Trim().EnsureEndsWith("/");
                string destFolder = destFolderTxt.Text.Trim().EnsureEndsWith("/");
                string choosenBranch = ChoosenBranchTxt.Text.Trim();
                string sourceBranch = sourceBranchTxt.Text.Trim();

                // Create a new process to run a command
                var process = new Process();
                process.StartInfo.WorkingDirectory = sourceFolder;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                if (chbAutoPullSource.Checked)
                {
                    WriteLog($"Pulling latest changes for source branch {sourceBranch}...");
                    process.StartInfo.Arguments = "/c git pull";
                    process.Start();
                    var pullResult = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    WriteLog(pullResult);
                }

                if (chbAutoPullChoosen.Checked)
                {
                    WriteLog($"Checking out and pulling latest changes for choosen branch {choosenBranch}...");
                    process.StartInfo.Arguments = $"/c git checkout {choosenBranch} && git pull";
                    process.Start();
                    var pullResult = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    WriteLog(pullResult);
                }

                // Run another command to get a list of changed files
                var cmd = $@"/c git diff --name-only {choosenBranch}..{sourceBranch}";
                process.StartInfo.Arguments = cmd;
                process.Start();
                var cmdOutput = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // If there are no changed files, display a message and exit
                if (string.IsNullOrWhiteSpace(cmdOutput))
                {
                    WriteLog("The operation has been completed. No files were changed.");
                    MessageBox.Show("The operation has been completed. No files were changed.");
                    return;
                }

                // Delete the destination folder if it exists and create it again
                if (Directory.Exists(destFolder))
                {
                    Directory.Delete(destFolder, true);
                }

                // Log the list of changed files
                WriteLog($"changed Files: \r\n{cmdOutput.Replace("\n", "\r\n")}");

                // Iterate over each changed file and copy it from the source folder to the destination folder
                var changedFiles = cmdOutput.Trim().Split('\n');
                foreach (var fileName in changedFiles)
                {
                    var srcFilePath = sourceFolder + fileName;
                    var destFilePath = destFolder + fileName;
                    try
                    {
                        var destDirectory = Path.GetDirectoryName(destFilePath);
                        Directory.CreateDirectory(destDirectory);
                        File.Copy(srcFilePath, destFilePath);
                        WriteLog($"The file {srcFilePath} has been copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        WriteLog($"Copying the file {srcFilePath} has failed. Details: {ex.Message}.");
                    }
                }

                // After copying all changed files, merge all files in each subdirectory of the destination folder into a single file with a .sql extension
                foreach (var directory in Directory.GetDirectories(destFolder))
                {
                    var mergedContent = new StringBuilder();
                    foreach (var file in Directory.GetFiles(directory))
                    {
                        // Read file content and remove zwnbsp character
                        var fileContent = File.ReadAllText(file);
                        fileContent = fileContent.Replace("\uFEFF", "");
                        mergedContent.Append(fileContent);
                        mergedContent.AppendLine();
                        mergedContent.AppendLine("GO");
                        mergedContent.AppendLine();
                    }
                    var mergedFileName = Path.GetFileName(directory) + ".sql";
                    var mergedFilePath = Path.Combine(destFolder, mergedFileName);
                    File.WriteAllText(mergedFilePath, mergedContent.ToString(), Encoding.Unicode);
                    WriteLog($"The merged file {mergedFileName} has been created.");
                }

                // Display a message indicating that the operation has completed
                WriteLog("The operation has been completed! Please refer to the log for more information.");
                MessageBox.Show("The operation has been completed! Please refer to the log for more information.");
            }
            catch (Exception ex)
            {
                WriteLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private void WriteLog(string content)
        {
            content = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{content}\r\n\r\n";
            logTxt.Text += content;
        }
    }
}
