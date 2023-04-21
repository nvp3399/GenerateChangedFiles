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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();


                var section = config.GetSection(nameof(DefaultConfig));
                var defaultConfig = section.Get<DefaultConfig>();

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


        private string GetCurrentBranch(string gitFolderPath)
        {

            var process = new Process();
            process.StartInfo.WorkingDirectory = gitFolderPath;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c git branch --show-current";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            var cmdOutput = process.StandardOutput.ReadToEnd();

            process.WaitForExit();
            return cmdOutput.Trim();
        }


        private void CopyChangedFilesBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string sourceFolder = sourceFolderTxt.Text.Trim().EnsureEndsWith("/");// = @"D:\git\sep.erp.sql\";
                string destFolder = destFolderTxt.Text.Trim().EnsureEndsWith("/");
                string choosenBranch = ChoosenBranchTxt.Text.Trim();
                string sourceBranch = sourceBranchTxt.Text.Trim();

                var cmd = $@"/c git checkout {choosenBranch}";

                var process = new Process();
                process.StartInfo.WorkingDirectory = sourceFolder;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = cmd;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;

                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                cmd = $@"/c git diff --name-only {choosenBranch}..{sourceBranch}";

                process.StartInfo.Arguments = cmd;

                process.Start();
                var cmdOutput = process.StandardOutput.ReadToEnd();

                process.WaitForExit();


                if (string.IsNullOrWhiteSpace(cmdOutput))
                {
                    WriteLog("Operation completed. No files changed.");
                    MessageBox.Show("Operation completed. No files changed.");
                    return;
                }
                if (Directory.Exists(destFolder))
                {
                    Directory.Delete(destFolder, true);
                }
                WriteLog($"changed Files: \r\n{cmdOutput.Replace("\n","\r\n")}");

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
                        WriteLog($"File {srcFilePath} copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        WriteLog($"Copy File {srcFilePath} failed. details: {ex.Message}");
                    }
                }
                WriteLog("Operation compeleted! Please read log for more info.");
                MessageBox.Show("Operation compeleted! Please read log for more info.");
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
