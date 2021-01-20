// ***********************************************************************
// Assembly         : PDFFormFieldReader
// Author           : David Swanson
// Created          : 09-18-2015
//
// Last Modified By : David Swanson
// Last Modified On : 10-02-2015
// ***********************************************************************
// <copyright file="MainForm.cs" company="">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

using iTextSharp.text.pdf;
using System.IO;

namespace PDFFormFieldReader
{
    /// <summary>
    /// Class MainForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        /// <summary>
        /// The form fields
        /// </summary>
        private readonly List<FormField> _formFields;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            SetDefaults();

            _formFields = new List<FormField>();
        }

        /// <summary>
        /// Sets the defaults.
        /// </summary>
        private void SetDefaults()
        {
            pnlSaveOptions.Enabled = false;
            cboFileType.SelectedIndex = 0;
            chkOpen.Checked = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnSelectFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            dlgFileOpen.Filter = "PDF Files (*.PDF)|*.pdf";
            dlgFileOpen.ShowDialog();

            txtPDFFile.Text = dlgFileOpen.FileName;
        }

        /// <summary>
        /// Handles the Click event of the BtnGenerateReport control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPDFFile.Text))
            {
                _formFields.Clear();

                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (FileStream fs = File.OpenRead(txtPDFFile.Text))
                        {
                            fs.CopyTo(ms);
                        }

                        PdfReader.unethicalreading = true;
                        PdfReader pdfReader = new PdfReader(ms.ToArray());
                        AcroFields pdfFormFields = pdfReader.AcroFields;

                        foreach (KeyValuePair<string, AcroFields.Item> kvp in pdfFormFields.Fields)
                        {
                            FormField formField = new FormField
                            {
                                FieldName = pdfFormFields.GetTranslatedFieldName(kvp.Key),
                                FieldValue = pdfFormFields.GetField(kvp.Key),
                                FieldType = GetFormFieldType(pdfFormFields.GetFieldType(kvp.Key))
                            };

                            AcroFields.Item field = pdfFormFields.GetFieldItem(kvp.Key);
                            PdfDictionary merged = field.GetMerged(0);
                            TextField fld = new TextField(null, null, null);
                            pdfFormFields.DecodeGenericDictionary(merged, fld);

                            formField.FontName = GetFontName(fld.Font);
                            string fontSize = (fld.FontSize == 0.0f) ? "Auto" : fld.FontSize.ToString();
                            formField.FontSize = fontSize;

                            List<AcroFields.FieldPosition> fieldPositions = pdfFormFields.GetFieldPositions(kvp.Key).ToList();
                            float pageHeight = pdfReader.GetPageSizeWithRotation(fieldPositions[0].page).Height;
                            formField.FieldPositionTop = (pageHeight - fieldPositions[0].position.Top);
                            formField.FieldPositionBottom = (pageHeight - fieldPositions[0].position.Bottom);
                            formField.FieldPositionLeft = fieldPositions[0].position.Left;
                            formField.FieldPositionRight = fieldPositions[0].position.Right;
                            formField.FieldHeight = fieldPositions[0].position.Height;
                            formField.FieldWidth = fieldPositions[0].position.Width;
                            formField.PageNumber = fieldPositions[0].page;

                            _formFields.Add(formField);
                        }

                        GenerateTreeViewDisplay();
                        pnlSaveOptions.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue with processing the request. Message: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnlSaveOptions.Enabled = pnlSaveOptions.Enabled ? true : false;
                }
            }
        }

        /// <summary>
        /// Generates the TreeView display.
        /// </summary>
        private void GenerateTreeViewDisplay()
        {
            tvFormFields.Nodes.Clear();
            int lastPageWithFields = _formFields.Max(ff => ff.PageNumber);
            int iterCount = 0;

            for (int i = 1; i <= lastPageWithFields; i++)
            {
                if (_formFields.Any(ff => ff.PageNumber == i))
                {
                    tvFormFields.Nodes.Add("Page " + i);
                    int pageIter = 0;
                    foreach (var formField in _formFields.Where(ff => ff.PageNumber == i))
                    {
                        tvFormFields.Nodes[iterCount].Nodes.Add("Field Name:  " + formField.FieldName);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes.Add("Field Value:  " + formField.FieldValue);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes.Add("Field Type:  " + formField.FieldType);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes.Add("Font");
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[2].Nodes.Add("Name:  " + formField.FontName);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[2].Nodes.Add("Size:  " + formField.FontSize);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes.Add("Field Positioning");
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[3].Nodes.Add("Top:  " + formField.FieldPositionTop);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[3].Nodes.Add("Bottom:  " + formField.FieldPositionBottom);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[3].Nodes.Add("Left:  " + formField.FieldPositionLeft);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[3].Nodes.Add("Right:  " + formField.FieldPositionRight);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[3].Nodes.Add("Width:  " + formField.FieldWidth);
                        tvFormFields.Nodes[iterCount].Nodes[pageIter].Nodes[3].Nodes.Add("Height:  " + formField.FieldHeight);
                        pageIter++;
                    }

                    iterCount++;
                }
            }
        }

        /// <summary>
        /// Generates the readable text format.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GenerateReadableTextFormat()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("==============================");
            foreach (var formField in _formFields)
            {
                sb.AppendLine("Field Name:  " + formField.FieldName);
                sb.AppendLine("Field Value:  " + formField.FieldValue);
                sb.AppendLine("Field Type:  " + formField.FieldType);
                sb.AppendLine("Font:");
                sb.AppendLine("    Name:  " + formField.FontName);
                sb.AppendLine("    Size:  " + formField.FontSize);
                sb.AppendLine("Field Positioning:");
                sb.AppendLine("    Top:  " + formField.FieldPositionTop);
                sb.AppendLine("    Bottom:  " + formField.FieldPositionBottom);
                sb.AppendLine("    Left:  " + formField.FieldPositionLeft);
                sb.AppendLine("    Right:  " + formField.FieldPositionRight);
                sb.AppendLine("    Height:  " + formField.FieldHeight);
                sb.AppendLine("    Width:  " + formField.FieldWidth);
                sb.AppendLine("    Page #:  " + formField.PageNumber);
                sb.AppendLine("==============================");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Generates the XML format.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GenerateXMLFormat()
        {
            StringWriter sw = new StringWriter();
            XmlSerializer x = new XmlSerializer(_formFields.GetType());
            x.Serialize(sw, _formFields);

            return sw.ToString();
        }

        /// <summary>
        /// Generates the json format.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GenerateJSONFormat()
        {
            var json = new JavaScriptSerializer().Serialize(_formFields);

            return json;
        }

        /// <summary>
        /// Generates the CSV format.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GenerateCSVFormat()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Field Name,Field Value,Field Type,Font Name,Font Size,Top,Bottom,Left,Right,Height,Width,Page #");
            foreach (var formField in _formFields)
            {
                sb.Append(formField.FieldName);
                sb.Append(",");
                sb.Append(formField.FieldValue);
                sb.Append(",");
                sb.Append(formField.FieldType);
                sb.Append(",");
                sb.Append(formField.FontName);
                sb.Append(",");
                sb.Append(formField.FontSize);
                sb.Append(",");
                sb.Append(formField.FieldPositionTop);
                sb.Append(",");
                sb.Append(formField.FieldPositionBottom);
                sb.Append(",");
                sb.Append(formField.FieldPositionLeft);
                sb.Append(",");
                sb.Append(formField.FieldPositionRight);
                sb.Append(",");
                sb.Append(formField.FieldHeight);
                sb.Append(",");
                sb.Append(formField.FieldWidth);
                sb.Append(",");
                sb.AppendLine(formField.PageNumber.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets the name of the font.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <returns>System.String.</returns>
        private string GetFontName(BaseFont font)
        {
            string fontName = "";
            foreach (string[] items in font.FullFontName)
            {
                foreach (string item in items)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        fontName = (fontName != "") ? fontName + ", " : "";
                        fontName += item;
                    }
                }
            }

            return fontName;
        }

        /// <summary>
        /// Gets the type of the form field.
        /// </summary>
        /// <param name="fieldType">Type of the field.</param>
        /// <returns>System.String.</returns>
        private string GetFormFieldType(int fieldType)
        {
            string fieldTypeName = "";

            switch (fieldType)
            {
                case AcroFields.FIELD_TYPE_PUSHBUTTON:
                    fieldTypeName = "Button";
                    break;

                case AcroFields.FIELD_TYPE_CHECKBOX:
                    fieldTypeName = "Checkbox";
                    break;

                case AcroFields.FIELD_TYPE_COMBO:
                case AcroFields.FIELD_TYPE_LIST:
                    fieldTypeName = "List";
                    break;

                case AcroFields.FIELD_TYPE_NONE:
                    fieldTypeName = "Unknown";
                    break;

                case AcroFields.FIELD_TYPE_RADIOBUTTON:
                    fieldTypeName = "Radio";
                    break;

                case AcroFields.FIELD_TYPE_SIGNATURE:
                    fieldTypeName = "Signature";
                    break;

                case AcroFields.FIELD_TYPE_TEXT:
                    fieldTypeName = "Text";
                    break;
            }

            return fieldTypeName;
        }

        /// <summary>
        /// Handles the Click event of the BtnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the BtnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dlgFileSave.Filter = cboFileType.SelectedItem.ToString();
                dlgFileSave.Title = "Save File";
                dlgFileSave.ShowDialog();

                if (dlgFileSave.FileName != "")
                {
                    using (FileStream fs = (FileStream)dlgFileSave.OpenFile())
                    {
                        using (StreamWriter s = new StreamWriter(fs))
                            s.Write(GetOutputForSelectedFormat());
                    }

                    MessageBox.Show("File " + dlgFileSave.FileName + " has been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (chkOpen.Checked)
                        System.Diagnostics.Process.Start(dlgFileSave.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue with processing the request. Message: \n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnPreview control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnPreview_Click(object sender, EventArgs e)
        {
            PreviewForm form = new PreviewForm(GetOutputForSelectedFormat());
            form.Show();
        }

        /// <summary>
        /// Gets the output for selected format.
        /// </summary>
        /// <returns>System.String.</returns>
        private string GetOutputForSelectedFormat()
        {
            string output;
            switch (cboFileType.SelectedItem.ToString())
            {
                case "XML File|*.xml":
                    output = GenerateXMLFormat();
                    break;

                case "JSON File|*.json":
                    output = GenerateJSONFormat();
                    break;

                case "CSV File|*.csv":
                    output = GenerateCSVFormat();
                    break;

                default:
                    output = GenerateReadableTextFormat();
                    break;
            }

            return output;
        }
    }
}
