
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceFolderTxt = new System.Windows.Forms.TextBox();
            this.destFolderTxt = new System.Windows.Forms.TextBox();
            this.sourceBranchTxt = new System.Windows.Forms.TextBox();
            this.ChoosenBranchTxt = new System.Windows.Forms.TextBox();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CopyChangedFilesBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.85506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.14494F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sourceFolderTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.destFolderTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceBranchTxt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ChoosenBranchTxt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.logTxt, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CopyChangedFilesBtn, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 680);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Source Branch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choosen Branch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceFolderTxt
            // 
            this.sourceFolderTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceFolderTxt.Location = new System.Drawing.Point(171, 3);
            this.sourceFolderTxt.Name = "sourceFolderTxt";
            this.sourceFolderTxt.Size = new System.Drawing.Size(635, 22);
            this.sourceFolderTxt.TabIndex = 4;
            // 
            // destFolderTxt
            // 
            this.destFolderTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destFolderTxt.Location = new System.Drawing.Point(171, 31);
            this.destFolderTxt.Name = "destFolderTxt";
            this.destFolderTxt.Size = new System.Drawing.Size(635, 22);
            this.destFolderTxt.TabIndex = 5;
            // 
            // sourceBranchTxt
            // 
            this.sourceBranchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceBranchTxt.Location = new System.Drawing.Point(171, 59);
            this.sourceBranchTxt.Name = "sourceBranchTxt";
            this.sourceBranchTxt.Size = new System.Drawing.Size(635, 22);
            this.sourceBranchTxt.TabIndex = 6;
            // 
            // ChoosenBranchTxt
            // 
            this.ChoosenBranchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoosenBranchTxt.Location = new System.Drawing.Point(171, 87);
            this.ChoosenBranchTxt.Name = "ChoosenBranchTxt";
            this.ChoosenBranchTxt.Size = new System.Drawing.Size(635, 22);
            this.ChoosenBranchTxt.TabIndex = 7;
            // 
            // logTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.logTxt, 2);
            this.logTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTxt.Location = new System.Drawing.Point(3, 178);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTxt.Size = new System.Drawing.Size(803, 499);
            this.logTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Log";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyChangedFilesBtn
            // 
            this.CopyChangedFilesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CopyChangedFilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyChangedFilesBtn.Location = new System.Drawing.Point(371, 115);
            this.CopyChangedFilesBtn.Name = "CopyChangedFilesBtn";
            this.CopyChangedFilesBtn.Size = new System.Drawing.Size(235, 40);
            this.CopyChangedFilesBtn.TabIndex = 10;
            this.CopyChangedFilesBtn.Text = "Copy changed files";
            this.CopyChangedFilesBtn.UseVisualStyleBackColor = true;
            this.CopyChangedFilesBtn.Click += new System.EventHandler(this.CopyChangedFilesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Copy Changed Files";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourceFolderTxt;
        private System.Windows.Forms.TextBox destFolderTxt;
        private System.Windows.Forms.TextBox sourceBranchTxt;
        private System.Windows.Forms.TextBox ChoosenBranchTxt;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CopyChangedFilesBtn;
    }
}

