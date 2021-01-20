namespace PDFFormFieldReader
{
    partial class MainForm
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
            this.txtPDFFile = new System.Windows.Forms.TextBox();
            this.lblPDFFile = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            this.tvFormFields = new System.Windows.Forms.TreeView();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.pnlSaveOptions = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlSaveOptions.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPDFFile
            // 
            this.txtPDFFile.Location = new System.Drawing.Point(50, 5);
            this.txtPDFFile.Name = "txtPDFFile";
            this.txtPDFFile.Size = new System.Drawing.Size(433, 20);
            this.txtPDFFile.TabIndex = 0;
            // 
            // lblPDFFile
            // 
            this.lblPDFFile.AutoSize = true;
            this.lblPDFFile.Location = new System.Drawing.Point(3, 8);
            this.lblPDFFile.Name = "lblPDFFile";
            this.lblPDFFile.Size = new System.Drawing.Size(50, 13);
            this.lblPDFFile.TabIndex = 1;
            this.lblPDFFile.Text = "PDF File:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(489, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(83, 21);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select &File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.InitialDirectory = "dlgFileOpen";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(3, 30);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(569, 23);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "&Display Field List";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save Result As ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(477, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tvFormFields
            // 
            this.tvFormFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFormFields.Location = new System.Drawing.Point(0, 0);
            this.tvFormFields.Name = "tvFormFields";
            this.tvFormFields.Size = new System.Drawing.Size(575, 539);
            this.tvFormFields.TabIndex = 7;
            // 
            // cboFileType
            // 
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Items.AddRange(new object[] {
            "XML File|*.xml",
            "JSON File|*.json",
            "CSV File|*.csv",
            "Text File|*.txt"});
            this.cboFileType.Location = new System.Drawing.Point(101, 9);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(121, 21);
            this.cboFileType.TabIndex = 8;
            // 
            // chkOpen
            // 
            this.chkOpen.Location = new System.Drawing.Point(228, 3);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(120, 35);
            this.chkOpen.TabIndex = 9;
            this.chkOpen.Text = "Open with default viewer after save?";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // pnlSaveOptions
            // 
            this.pnlSaveOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSaveOptions.Controls.Add(this.btnPreview);
            this.pnlSaveOptions.Controls.Add(this.btnSave);
            this.pnlSaveOptions.Controls.Add(this.chkOpen);
            this.pnlSaveOptions.Controls.Add(this.cboFileType);
            this.pnlSaveOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlSaveOptions.Name = "pnlSaveOptions";
            this.pnlSaveOptions.Size = new System.Drawing.Size(468, 42);
            this.pnlSaveOptions.TabIndex = 10;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(377, 6);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.AutoSize = true;
            this.pnlBody.Controls.Add(this.tvFormFields);
            this.pnlBody.Location = new System.Drawing.Point(0, 59);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(575, 539);
            this.pnlBody.TabIndex = 11;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnGenerateReport);
            this.pnlHeader.Controls.Add(this.txtPDFFile);
            this.pnlHeader.Controls.Add(this.lblPDFFile);
            this.pnlHeader.Controls.Add(this.btnSelectFile);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(575, 58);
            this.pnlHeader.TabIndex = 12;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.pnlSaveOptions);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 596);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(575, 48);
            this.pnlFooter.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 644);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "PDF Form Field Reader";
            this.pnlSaveOptions.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPDFFile;
        private System.Windows.Forms.Label lblPDFFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog dlgFileOpen;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
        private System.Windows.Forms.TreeView tvFormFields;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.CheckBox chkOpen;
        private System.Windows.Forms.Panel pnlSaveOptions;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
    }
}

