using System;
using System.Collections.Generic;
using System.Drawing;
using TriangleCoordinates.Lib;


/// <summary>
/// Utility classes for TriangleCoordinates
/// </summary>
namespace TriangleCoordinates.Util
{
    /// <summary>Static Class Validations encapsulates static utility methods for use throughout the solution.</summary>
    public static class Validations
    {
        #region public helper methods
        /// <summary>Validates the triangle points in grid.</summary>
        /// <param name="grid">The grid.</param>
        /// <param name="triangle">The triangle.</param>
        /// <returns></returns>
        public static bool ValidateTrianglePointsInGrid(Grid grid, Triangle triangle)
        {
            return triangle.Point1.X <= grid.Length && triangle.Point1.Y <= grid.Height 
                && triangle.Point2.X <= grid.Length && triangle.Point2.Y <= grid.Height
                && triangle.Point3.X <= grid.Length && triangle.Point3.Y <= grid.Height;
        }

        /// <summary>Validates if triangle is an isosceles right triangle.</summary>
        /// <param name="triangle">The triangle.</param>
        /// <returns></returns>
        public static bool ValidateIsIsoscelesRightTriangle(Triangle triangle)
        {
            int hypotenuseCount = 0;

            if (Calculations.GetDistanceBetweenPoints(triangle.Point1, triangle.Point2)
                != Convert.ToDouble(Constants.CELL_SIZE))
            {
                hypotenuseCount++;
            }

            if (Calculations.GetDistanceBetweenPoints(triangle.Point2, triangle.Point3)
                != Convert.ToDouble(Constants.CELL_SIZE))
            {
                hypotenuseCount++;
            }

            if (Calculations.GetDistanceBetweenPoints(triangle.Point1, triangle.Point3)
                != Convert.ToDouble(Constants.CELL_SIZE))
            {
                hypotenuseCount++;
            }

            if (hypotenuseCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>Validates the cell location in grid.</summary>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns></returns>
        public static bool ValidateCellLocationInGrid(string cellLocation)
        {
            if (cellLocation.Length < 2 || !char.IsLetter(cellLocation[0]) ||
                !int.TryParse(cellLocation.Substring(1), out int column))
            {
                return false;
            }
            else
            {
                return (((double)column / 2d) <= (double)Constants.COLUMN_COUNT);
            }
        }
        #endregion
    }
}
