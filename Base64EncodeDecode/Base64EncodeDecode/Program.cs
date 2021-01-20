// ***********************************************************************
// Assembly         : Base64EncodeDecode
// Author           : David Swanson
// Created          : 08-08-2014
//
// Last Modified By : David Swanson
// Last Modified On : 08-08-2014
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace Base64EncodeDecode
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
            Application.Run(new frmMain());
        }
    }
}
