using System;


/// <summary>
/// Library classes for TriangleCoordinates
/// </summary>
namespace TriangleCoordinates.Lib
{
    /// <summary>Class Grid encapsulates methods/properties for defining a grid.</summary>
    public class Grid
    {
        #region private properties
        private int _rowCount;
        private int _columnCount;
        private int _cellSize;
        #endregion

        /// <summary>Initializes a new instance of the <see cref="Grid"/> class.</summary>
        /// <param name="rowCount">The row count.</param>
        /// <param name="columnCount">The column count.</param>
        /// <param name="cellSize">Size of the cell.</param>
        public Grid(int rowCount, int columnCount, int cellSize)
        {
            _rowCount = rowCount;
            _columnCount = columnCount;
            _cellSize = cellSize;
        }

        #region public getter methods
        /// <summary>Gets the size of the cell.</summary>
        /// <value>The size of the cell.</value>
        public int CellSize
        {
            get { return _cellSize; }
        }

        /// <summary>Gets the length.</summary>
        /// <value>The length.</value>
        public int Length
        {
            get { return _columnCount * _cellSize; }
        }

        /// <summary>Gets the height.</summary>
        /// <value>The height.</value>
        public int Height
        {
            get { return _rowCount * _cellSize; }
        }
        #endregion
    }
}
