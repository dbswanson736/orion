// ***********************************************************************
// Assembly         : PDFFormFieldReader
// Author           : David Swanson
// Created          : 09-18-2015
//
// Last Modified By : David Swanson
// Last Modified On : 10-02-2015
// ***********************************************************************
// <copyright file="PreviewForm.cs" company="">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace PDFFormFieldReader
{
    /// <summary>
    /// Class PreviewForm.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PreviewForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewForm"/> class.
        /// </summary>
        public PreviewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewForm"/> class.
        /// </summary>
        /// <param name="textToDisplay">The text to display.</param>
        public PreviewForm(string textToDisplay)
        {
            InitializeComponent();
            rtbPreview.Text = textToDisplay;
        }
    }
}
