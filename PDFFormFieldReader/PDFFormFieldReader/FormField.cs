// ***********************************************************************
// Assembly         : PDFFormFieldReader
// Author           : David Swanson
// Created          : 09-18-2015
//
// Last Modified By : David Swanson
// Last Modified On : 10-02-2015
// ***********************************************************************
// <copyright file="FormField.cs" company="">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

/// <summary>
/// The PDFFormFieldReader namespace.
/// </summary>
namespace PDFFormFieldReader
{
    /// <summary>
    /// Class FormField.
    /// </summary>
    public class FormField
    {
        /// <summary>
        /// The field name
        /// </summary>
        private string _fieldName;
        /// <summary>
        /// The field value
        /// </summary>
        private string _fieldValue;
        /// <summary>
        /// The field type
        /// </summary>
        private string _fieldType;
        /// <summary>
        /// The font name
        /// </summary>
        private string _fontName;
        /// <summary>
        /// The font size
        /// </summary>
        private string _fontSize;
        /// <summary>
        /// The field position top
        /// </summary>
        private float _fieldPositionTop;
        /// <summary>
        /// The field position bottom
        /// </summary>
        private float _fieldPositionBottom;
        /// <summary>
        /// The field position right
        /// </summary>
        private float _fieldPositionRight;
        /// <summary>
        /// The field position left
        /// </summary>
        private float _fieldPositionLeft;
        /// <summary>
        /// The field width
        /// </summary>
        private float _fieldWidth;
        /// <summary>
        /// The field height
        /// </summary>
        private float _fieldHeight;
        /// <summary>
        /// The page number
        /// </summary>
        private int _pageNumber;


        /// <summary>
        /// Initializes a new instance of the <see cref="FormField"/> class.
        /// </summary>
        public FormField() { }

        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
        public string FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
        }

        /// <summary>
        /// Gets or sets the field value.
        /// </summary>
        /// <value>The field value.</value>
        public string FieldValue
        {
            get { return _fieldValue; }
            set { _fieldValue = value; }
        }

        /// <summary>
        /// Gets or sets the type of the field.
        /// </summary>
        /// <value>The type of the field.</value>
        public string FieldType
        {
            get { return _fieldType; }
            set { _fieldType = value; }
        }

        /// <summary>
        /// Gets or sets the name of the font.
        /// </summary>
        /// <value>The name of the font.</value>
        public string FontName
        {
            get { return _fontName; }
            set { _fontName = value; }
        }

        /// <summary>
        /// Gets or sets the size of the font.
        /// </summary>
        /// <value>The size of the font.</value>
        public string FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        /// <summary>
        /// Gets or sets the field position top.
        /// </summary>
        /// <value>The field position top.</value>
        public float FieldPositionTop
        {
            get { return _fieldPositionTop; }
            set { _fieldPositionTop = value; }
        }

        /// <summary>
        /// Gets or sets the field position bottom.
        /// </summary>
        /// <value>The field position bottom.</value>
        public float FieldPositionBottom
        {
            get { return _fieldPositionBottom; }
            set { _fieldPositionBottom = value; }
        }

        /// <summary>
        /// Gets or sets the field position right.
        /// </summary>
        /// <value>The field position right.</value>
        public float FieldPositionRight
        {
            get { return _fieldPositionRight; }
            set { _fieldPositionRight = value; }
        }

        /// <summary>
        /// Gets or sets the field position left.
        /// </summary>
        /// <value>The field position left.</value>
        public float FieldPositionLeft
        {
            get { return _fieldPositionLeft; }
            set { _fieldPositionLeft = value; }
        }

        /// <summary>
        /// Gets or sets the width of the field.
        /// </summary>
        /// <value>The width of the field.</value>
        public float FieldWidth
        {
            get { return _fieldWidth; }
            set { _fieldWidth = value; }
        }

        /// <summary>
        /// Gets or sets the height of the field.
        /// </summary>
        /// <value>The height of the field.</value>
        public float FieldHeight
        {
            get { return _fieldHeight; }
            set { _fieldHeight = value; }
        }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>The page number.</value>
        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value; }
        }
    }
}
