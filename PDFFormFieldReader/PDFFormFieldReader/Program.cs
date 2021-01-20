// ***********************************************************************
// Assembly         : PDFFormFieldReader
// Author           : David Swanson
// Created          : 09-18-2015
//
// Last Modified By : David Swanson
// Last Modified On : 09-18-2015
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace PDFFormFieldReader
{
    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
