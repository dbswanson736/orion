// ***********************************************************************
// Assembly         : Base64EncodeDecode
// Author           : David Swanson
// Created          : 08-08-2014
//
// Last Modified By : David Swanson
// Last Modified On : 08-08-2014
// ***********************************************************************
// <copyright file="FileObject.cs" company="">
//     Copyright ©  2014
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace Base64EncodeDecode
{
    /// <summary>
    /// Class FileObject.
    /// </summary>
    public class FileObject
    {
        /// <summary>
        /// The file name
        /// </summary>
        private string _fileName;
        /// <summary>
        /// The file data
        /// </summary>
        private byte[] _fileData;

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        /// Gets or sets the file data.
        /// </summary>
        /// <value>The file data.</value>
        public byte [] FileData
        {
            get { return _fileData; }
            set { _fileData = value; }
        }
    }
}
