namespace Base64EncodeDecode
{
    partial class ResultsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.btnSaveResultAsFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(123, 568);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(111, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Cop&y to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 568);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // rtbResults
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbResults, 4);
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Location = new System.Drawing.Point(3, 3);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(773, 559);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // btnSaveResultAsFile
            // 
            this.btnSaveResultAsFile.Enabled = false;
            this.btnSaveResultAsFile.Location = new System.Drawing.Point(3, 568);
            this.btnSaveResultAsFile.Name = "btnSaveResultAsFile";
            this.btnSaveResultAsFile.Size = new System.Drawing.Size(114, 23);
            this.btnSaveResultAsFile.TabIndex = 2;
            this.btnSaveResultAsFile.Text = "&Save Result As File";
            this.btnSaveResultAsFile.UseVisualStyleBackColor = true;
            this.btnSaveResultAsFile.Click += new System.EventHandler(this.BtnSaveResultAsFile_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbResults, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveResultAsFile, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 597);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResultsControl";
            this.Size = new System.Drawing.Size(779, 597);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSaveResultAsFile;
    }
}
