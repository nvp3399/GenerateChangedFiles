
namespace GenerateChangedFiles
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
            this.chbAutoPullChoosen = new System.Windows.Forms.CheckBox();
            this.chbAutoPullSource = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.85506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.14494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel1.Controls.Add(this.chbAutoPullSource, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chbAutoPullChoosen, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Source Branch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choosen Branch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceFolderTxt
            // 
            this.sourceFolderTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceFolderTxt.Location = new System.Drawing.Point(105, 2);
            this.sourceFolderTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sourceFolderTxt.Name = "sourceFolderTxt";
            this.sourceFolderTxt.Size = new System.Drawing.Size(389, 20);
            this.sourceFolderTxt.TabIndex = 4;
            // 
            // destFolderTxt
            // 
            this.destFolderTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destFolderTxt.Location = new System.Drawing.Point(105, 26);
            this.destFolderTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.destFolderTxt.Name = "destFolderTxt";
            this.destFolderTxt.Size = new System.Drawing.Size(389, 20);
            this.destFolderTxt.TabIndex = 5;
            // 
            // sourceBranchTxt
            // 
            this.sourceBranchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceBranchTxt.Location = new System.Drawing.Point(105, 50);
            this.sourceBranchTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sourceBranchTxt.Name = "sourceBranchTxt";
            this.sourceBranchTxt.Size = new System.Drawing.Size(389, 20);
            this.sourceBranchTxt.TabIndex = 6;
            // 
            // ChoosenBranchTxt
            // 
            this.ChoosenBranchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoosenBranchTxt.Location = new System.Drawing.Point(105, 74);
            this.ChoosenBranchTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChoosenBranchTxt.Name = "ChoosenBranchTxt";
            this.ChoosenBranchTxt.Size = new System.Drawing.Size(389, 20);
            this.ChoosenBranchTxt.TabIndex = 7;
            // 
            // logTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.logTxt, 3);
            this.logTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTxt.Location = new System.Drawing.Point(2, 147);
            this.logTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTxt.Size = new System.Drawing.Size(603, 403);
            this.logTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Log";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyChangedFilesBtn
            // 
            this.CopyChangedFilesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyChangedFilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyChangedFilesBtn.Location = new System.Drawing.Point(318, 98);
            this.CopyChangedFilesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyChangedFilesBtn.Name = "CopyChangedFilesBtn";
            this.CopyChangedFilesBtn.Size = new System.Drawing.Size(176, 32);
            this.CopyChangedFilesBtn.TabIndex = 10;
            this.CopyChangedFilesBtn.Text = "Copy changed files";
            this.CopyChangedFilesBtn.UseVisualStyleBackColor = true;
            this.CopyChangedFilesBtn.Click += new System.EventHandler(this.CopyChangedFilesBtn_Click);
            // 
            // chbAutoPullChoosen
            // 
            this.chbAutoPullChoosen.AutoSize = true;
            this.chbAutoPullChoosen.Checked = true;
            this.chbAutoPullChoosen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoPullChoosen.Location = new System.Drawing.Point(499, 75);
            this.chbAutoPullChoosen.Name = "chbAutoPullChoosen";
            this.chbAutoPullChoosen.Size = new System.Drawing.Size(104, 17);
            this.chbAutoPullChoosen.TabIndex = 11;
            this.chbAutoPullChoosen.Text = "Pull Before Copy";
            this.chbAutoPullChoosen.UseVisualStyleBackColor = true;
            // 
            // chbAutoPullSource
            // 
            this.chbAutoPullSource.AutoSize = true;
            this.chbAutoPullSource.Checked = true;
            this.chbAutoPullSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoPullSource.Location = new System.Drawing.Point(499, 51);
            this.chbAutoPullSource.Name = "chbAutoPullSource";
            this.chbAutoPullSource.Size = new System.Drawing.Size(104, 17);
            this.chbAutoPullSource.TabIndex = 12;
            this.chbAutoPullSource.Text = "Pull Before Copy";
            this.chbAutoPullSource.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.CheckBox chbAutoPullSource;
        private System.Windows.Forms.CheckBox chbAutoPullChoosen;
    }
}

