namespace Base64EncodeDecode
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabForms = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdoFileFormat = new System.Windows.Forms.RadioButton();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.rdoTextString = new System.Windows.Forms.RadioButton();
            this.btnPasteFromClipboard = new System.Windows.Forms.Button();
            this.rtbInputText = new System.Windows.Forms.RichTextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForms.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForms
            // 
            this.tabForms.Controls.Add(this.tabPage1);
            this.tabForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForms.Location = new System.Drawing.Point(0, 24);
            this.tabForms.Name = "tabForms";
            this.tabForms.SelectedIndex = 0;
            this.tabForms.Size = new System.Drawing.Size(784, 538);
            this.tabForms.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.rdoFileFormat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFileName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenFile, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdoTextString, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPasteFromClipboard, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rtbInputText, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEncode, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDecode, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 6, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 506);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // rdoFileFormat
            // 
            this.rdoFileFormat.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rdoFileFormat, 7);
            this.rdoFileFormat.Location = new System.Drawing.Point(13, 13);
            this.rdoFileFormat.Name = "rdoFileFormat";
            this.rdoFileFormat.Size = new System.Drawing.Size(246, 17);
            this.rdoFileFormat.TabIndex = 5;
            this.rdoFileFormat.TabStop = true;
            this.rdoFileFormat.Text = "File - Multiples supported using \";\" as separator";
            this.rdoFileFormat.UseVisualStyleBackColor = true;
            this.rdoFileFormat.CheckedChanged += new System.EventHandler(this.RdoFileFormat_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.AllowDrop = true;
            this.tableLayoutPanel1.SetColumnSpan(this.txtFileName, 6);
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileName.Location = new System.Drawing.Point(13, 38);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(713, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(732, 38);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(25, 20);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // rdoTextString
            // 
            this.rdoTextString.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rdoTextString, 7);
            this.rdoTextString.Location = new System.Drawing.Point(13, 68);
            this.rdoTextString.Name = "rdoTextString";
            this.rdoTextString.Size = new System.Drawing.Size(52, 17);
            this.rdoTextString.TabIndex = 6;
            this.rdoTextString.TabStop = true;
            this.rdoTextString.Text = "String";
            this.rdoTextString.UseVisualStyleBackColor = true;
            this.rdoTextString.CheckedChanged += new System.EventHandler(this.RdoTextString_CheckedChanged);
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPasteFromClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPasteFromClipboard.Location = new System.Drawing.Point(13, 93);
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(27, 380);
            this.btnPasteFromClipboard.TabIndex = 7;
            this.btnPasteFromClipboard.Text = "=> P A S T E  =>";
            this.btnPasteFromClipboard.UseVisualStyleBackColor = false;
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.BtnPasteFromClipboard_Click);
            // 
            // rtbInputText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbInputText, 6);
            this.rtbInputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInputText.Location = new System.Drawing.Point(46, 93);
            this.rtbInputText.Name = "rtbInputText";
            this.rtbInputText.Size = new System.Drawing.Size(711, 380);
            this.rtbInputText.TabIndex = 5;
            this.rtbInputText.Text = "";
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEncode.Location = new System.Drawing.Point(302, 479);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(80, 23);
            this.btnEncode.TabIndex = 11;
            this.btnEncode.Text = "&Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDecode.Location = new System.Drawing.Point(388, 479);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(80, 23);
            this.btnDecode.TabIndex = 12;
            this.btnDecode.Text = "&Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(621, 479);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.btnExit, 2);
            this.btnExit.Location = new System.Drawing.Point(701, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearTabs,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Padding = new System.Windows.Forms.Padding(1, 0, 4, 0);
            this.tsmiFile.Size = new System.Drawing.Size(34, 20);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiClearTabs
            // 
            this.tsmiClearTabs.Name = "tsmiClearTabs";
            this.tsmiClearTabs.Size = new System.Drawing.Size(152, 22);
            this.tsmiClearTabs.Text = "&Clear Tabs";
            this.tsmiClearTabs.Click += new System.EventHandler(this.TsmiClearTabs_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "&Exit";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnEncode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabForms);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.Text = "Base64EncodeDecode";
            this.tabForms.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabForms;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbInputText;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.RadioButton rdoTextString;
        private System.Windows.Forms.RadioButton rdoFileFormat;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnPasteFromClipboard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearTabs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

