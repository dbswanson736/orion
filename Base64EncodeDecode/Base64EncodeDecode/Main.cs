// ***********************************************************************
// Assembly         : Base64EncodeDecode
// Author           : David Swanson
// Created          : 08-08-2014
//
// Last Modified By : David Swanson
// Last Modified On : 08-10-2014
// ***********************************************************************
// <copyright file="Main.cs" company="">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Base64EncodeDecode
{
    /// <summary>
    /// Class frmMain.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmMain : Form
    {
        /// <summary>
        /// The data
        /// </summary>
        private readonly List<FileObject> _data = new List<FileObject>();
        /// <summary>
        /// The input file path
        /// </summary>
        private string _inputFilePath = null;
        /// <summary>
        /// The string input tab count
        /// </summary>
        private int _stringInputTabCount = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain" /> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            ResetForm();
            _inputFilePath = "c:\\";
            _stringInputTabCount = 0;

            txtFileName.AllowDrop = true;
            txtFileName.DragOver += new DragEventHandler(DropFileInControlt_DragOver);
            txtFileName.DragDrop += new DragEventHandler(DropFileInControlt_DragDrop);

            rtbInputText.AllowDrop = true;
            rtbInputText.DragOver += new DragEventHandler(DropFileInControlt_DragOver);
            rtbInputText.DragDrop += new DragEventHandler(DropFileInControlt_DragDrop);
        }

        /// <summary>
        /// Handles the DragOver event of the DropFileInControlt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void DropFileInControlt_DragOver(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;

        }

        /// <summary>
        /// Handles the DragDrop event of the DropFileInControlt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DragEventArgs"/> instance containing the event data.</param>
        private void DropFileInControlt_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData("FileDrop") != null)
            {
                string[] names = e.Data.GetData("FileDrop") as string[];

                if (sender is TextBox)
                {
                    int fileCount = 0;
                    foreach (string fileName in names)
                    {
                        if (fileCount++ == 0)
                            ((TextBox)sender).Text = fileName;
                        else
                            ((TextBox)sender).Text += ";" + fileName;
                    }
                }
                else if (sender is RichTextBox)
                {
                    if (names.Length > 1)
                    {
                        MessageBox.Show("Control only supports Drag and Drop for 1 file at a time.", "Failed to Drag and Drop File");
                    }
                    else
                    {
                        try
                        {
                            using (Stream stream = File.Open(names[0], FileMode.Open, FileAccess.Read))
                            {
                                byte[] data = new byte[(int)stream.Length];
                                stream.Read(data, 0, (int)stream.Length);
                                string dataString = GetString(data);
                                if (dataString.Contains("\0\0"))
                                {
                                    MessageBox.Show("The decoded data appears to be binary and can not be displayed as text.  File name has been placed in the file name entry section instead.", "Binary Data Detected", MessageBoxButtons.OK);
                                    txtFileName.Text = names[0];
                                    rdoFileFormat.Checked = true;
                                }
                                else
                                {
                                    ((RichTextBox)sender).Text = dataString;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnOpenFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                _data.Clear();
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = _inputFilePath,
                    Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    Multiselect = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    int fileCount = 0;
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        if (fileCount++ == 0)
                            txtFileName.Text = file;
                        else
                            txtFileName.Text += ";" + file;
                    }

                    _inputFilePath = Path.GetDirectoryName(openFileDialog1.FileNames[0]);
                }

                openFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the rdoFileFormat control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RdoFileFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFileFormat.Checked)
            {
                txtFileName.Enabled = true;
                btnOpenFile.Enabled = true;
                btnPasteFromClipboard.Enabled = false;
                rtbInputText.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the rdoTextString control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RdoTextString_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTextString.Checked)
            {
                txtFileName.Enabled = false;
                btnOpenFile.Enabled = false;
                btnPasteFromClipboard.Enabled = true;
                rtbInputText.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            _data.Clear();

            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the btnEncode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoFileFormat.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtFileName.Text))
                    {
                        MessageBox.Show("Please select a file to Encode.");
                    }
                    else
                    {
                        LoadFileObjects();
                        if (_data.Count == 1)
                        {
                            AddTab("Results for " + _data[0], _data[0], EncodeFile(_data[0].FileData));
                        }
                        else if (_data.Count > 1)
                        {
                            foreach (FileObject data in _data)
                            {
                                try
                                {
                                    AddTab("Results for " + data.FileName, data, EncodeFile(data.FileData));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message, "Error");
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(rtbInputText.Text))
                    {
                        MessageBox.Show("Please provide a string to Encode.");
                    }
                    else
                    {
                        byte[] data = GetBytes(rtbInputText.Text);
                        string dataString = EncodeFile(data);
                        string fileName = (_inputFilePath.EndsWith("\\")) ? string.Concat(_inputFilePath, "base64.tmp") : string.Concat(_inputFilePath, "\\base64.tmp");
                        FileObject fileData = new FileObject() { FileName = fileName, FileData = GetBytes(dataString) };
                        AddTab(string.Concat("Results for String input (", ++_stringInputTabCount, ")"), fileData, dataString);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDecode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoFileFormat.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtFileName.Text))
                    {
                        MessageBox.Show("Please select a file to Decode.");
                    }
                    else
                    {
                        LoadFileObjects();
                        if (_data.Count == 1)
                        {
                            AddTab("Results for " + _data[0].FileName, _data[0], DecodeFile(_data[0].FileData));
                        }
                        else if (_data.Count > 1)
                        {
                            foreach (FileObject data in _data)
                            {
                                try
                                {
                                    AddTab("Results for " + data.FileName, data, DecodeFile(data.FileData));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message, "Error");
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(rtbInputText.Text))
                    {
                        MessageBox.Show("Please provide a string to Decode.");
                    }
                    else
                    {
                        byte[] data = GetBytes(rtbInputText.Text);
                        string dataString = DecodeFile(data);
                        if (dataString.Contains("\0\0"))
                        {
                            MessageBox.Show("The decoded data appears to be binary and can not be displayed as text.  Please continue and save the result as a file.", "Binary Data Detected", MessageBoxButtons.OK);

                            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                            {
                                InitialDirectory = _inputFilePath,
                                DefaultExt = ".tmp",
                                FileName = "base64",
                                FilterIndex = 1,
                                Filter = "All Files|*.*"
                            };

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                File.WriteAllBytes(saveFileDialog1.FileName, GetBytes(dataString));
                                MessageBox.Show("Results saved as file successfully!", "File Saved");
                            }

                            saveFileDialog1.Dispose();
                        }
                        else
                        {

                            string fileName = (_inputFilePath.EndsWith("\\")) ? string.Concat(_inputFilePath, "base64.tmp") : string.Concat(_inputFilePath, "\\base64.tmp");
                            FileObject fileData = new FileObject() { FileName = fileName, FileData = GetBytes(dataString) };
                            AddTab(string.Concat("Results for String input (", ++_stringInputTabCount, ")"), fileData, dataString);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void ResetForm()
        {
            rdoFileFormat.Checked = true;
            txtFileName.Text = "";
            rtbInputText.Text = "";
            btnPasteFromClipboard.Enabled = false;
            _data.Clear();
        }

        /// <summary>
        /// Encodes the file.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        private string EncodeFile(byte[] data)
        {
            try
            {
                return Convert.ToBase64String(data);
            }
            catch (Exception ex)
            {
                return "Input is not in a format that is valid for selected Action.  Original error: " + ex.Message;
            }
        }

        /// <summary>
        /// Decodes the file.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>System.String.</returns>
        private string DecodeFile(byte [] data)
        {
            try
            {
                string dataString = GetString(data);

                //this will fail to convert if data was not a base64 string
                byte[] b = Convert.FromBase64String(dataString);
                return GetString(b);
            }
            catch (Exception ex)
            {
                return "Input is not in a format that is valid for selected Action.  Original error: " + ex.Message;
            }
        }

        /// <summary>
        /// Loads the file objects.
        /// </summary>
        private void LoadFileObjects()
        {
            _data.Clear();
            if (!string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                int fileCount = 0;
                string[] files = txtFileName.Text.Split(';');
                foreach (string file in files)
                {
                    try
                    {
                        if (fileCount++ == 0)
                            txtFileName.Text = file;
                        else
                            txtFileName.Text += "; " + file;

                        using (Stream stream = File.Open(file, FileMode.Open, FileAccess.Read))
                        {
                            byte[] data = new byte[(int)stream.Length];
                            stream.Read(data, 0, (int)stream.Length);
                            _data.Add(new FileObject() { FileName = file.Trim(), FileData = data });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error");
                    }
                }

                _inputFilePath = Path.GetDirectoryName(files[0]);
            }
        }

        /// <summary>
        /// Adds the tab.
        /// </summary>
        /// <param name="tabName">Name of the tab.</param>
        /// <param name="data">The data.</param>
        /// <param name="results">The results.</param>
        public void AddTab(string tabName, FileObject data, string results)
        {
            TabPage tbp = new TabPage
            {
                Name = "tab" + tabForms.TabPages.Count.ToString(),
                Text = tabName
            };
            ResultsControl cnt = new ResultsControl(data, results, ref tabForms)
            {
                Name = tbp.Name + "_cnt",
                Dock = DockStyle.Fill
            };
            tbp.Controls.Add(cnt);
            tabForms.TabPages.Add(tbp);
            cnt.Show();
            cnt.Select();
        }

        /// <summary>
        /// Gets the bytes.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>System.Byte[].</returns>
        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// Gets the string.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>System.String.</returns>
        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        /// <summary>
        /// Handles the Click event of the btnPasteFromClipboard control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            rtbInputText.Text = Clipboard.GetText();
        }

        /// <summary>
        /// Handles the Click event of the tsmiExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TsmiExit_Click(object sender, EventArgs e)
        {
            _data.Clear();

            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the tsmiClearTabs control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TsmiClearTabs_Click(object sender, EventArgs e)
        {
            _stringInputTabCount = 0;
            foreach (TabPage page in tabForms.TabPages)
            {
                if (page.Name != "mainTabPage")
                    tabForms.TabPages.Remove(page);
            }
        }
    }
}
