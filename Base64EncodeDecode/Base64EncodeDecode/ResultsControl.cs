// ***********************************************************************
// Assembly         : Base64EncodeDecode
// Author           : David Swanson
// Created          : 08-08-2014
//
// Last Modified By : David Swanson
// Last Modified On : 08-10-2014
// ***********************************************************************
// <copyright file="ResultsControl.cs" company="">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using System.IO;

namespace Base64EncodeDecode
{
    /// <summary>
    /// Class ResultsControl.
    /// Implements the <see cref="System.Windows.Forms.UserControl" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ResultsControl : UserControl
    {
        /// <summary>
        /// The data
        /// </summary>
        readonly FileObject _data;

        /// <summary>
        /// The tab control
        /// </summary>
        readonly TabControl _tabControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsControl"/> class.
        /// </summary>
        public ResultsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsControl"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="results">The results.</param>
        /// <param name="tabControl">The tab control.</param>
        public ResultsControl(FileObject data, string results, ref TabControl tabControl)
        {
            InitializeComponent();
            _data = data;
            _tabControl = tabControl;
            this.Text = "Results for " + _data.FileName;
            rtbResults.Text = results;
            if (!results.StartsWith("Input is not in a format that is valid for selected Action."))
                btnSaveResultAsFile.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            _tabControl.TabPages.Remove((TabPage)this.Parent);
        }

        /// <summary>
        /// Handles the Click event of the btnSaveResultAsFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSaveResultAsFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = Path.GetDirectoryName(_data.FileName),
                DefaultExt = ".tmp",
                FileName = "base64",
                FilterIndex = 1,
                Filter = "All Files|*.*"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, _data.FileData);
            }

            saveFileDialog1.Dispose();
        }

        /// <summary>
        /// Handles the Click event of the btnCopy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbResults.Text);
        }
    }
}
