using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TriangleCoordinates.Lib;


/// <summary>
/// Utility classes for TriangleCoordinates
/// </summary>
namespace TriangleCoordinates.Util
{
    /// <summary>Static Class Calculations encapsulates static utility methods for use throughout the solution.</summary>
    public static class Calculations
    {
        #region public helper methods
        /// <summary>Gets the triangle from cell location.</summary>
        /// <param name="grid">The grid.</param>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Invalid cell coordinates:  " + cellLocation</exception>
        public static Triangle GetTriangleFromCellLocation(Grid grid, string cellLocation)
        {
            if(Validations.ValidateCellLocationInGrid(cellLocation) == false)
            {
                throw new Exception("Invalid cell coordinates:  " + cellLocation);
            }

            int column = int.Parse(cellLocation.Substring(1));
            Point startingPoint = GetCellLocationStartingPoint(grid, cellLocation);

            Triangle triangle;
            if (column % 2 == 0)
            {
                //Top triangle
                triangle = new Triangle(new Point(startingPoint.X, startingPoint.Y),
                    new Point(startingPoint.X + grid.CellSize, startingPoint.Y),
                    new Point(startingPoint.X + grid.CellSize, startingPoint.Y + grid.CellSize));
            }
            else
            {
                //Bottom triangle
                triangle = new Triangle(new Point(startingPoint.X, startingPoint.Y),
                    new Point(startingPoint.X, startingPoint.Y + grid.CellSize),
                    new Point(startingPoint.X + grid.CellSize, startingPoint.Y + grid.CellSize));
            }

            return triangle;
        }

        /// <summary>Gets the cell location from triangle.</summary>
        /// <param name="grid">The grid.</param>
        /// <param name="triangle">The triangle.</param>
        /// <returns></returns>
        /// <exception cref="Exception">
        /// Invalid triangle coordinates:  Triangle is outside of the grid
        /// or
        /// Invalid Isosceles Right Triangle: More than one side does not match the defined cell size of " + Constants.CELL_SIZE
        /// </exception>
        public static string GetCellLocationFromTriangle(Grid grid, Triangle triangle)
        {
            if (Validations.ValidateTrianglePointsInGrid(grid, triangle) == false)
            {
                throw new Exception("Invalid triangle coordinates:  Triangle is outside of the grid");
            }
            else if (Validations.ValidateIsIsoscelesRightTriangle(triangle) == false)
            {
                throw new Exception("Invalid Isosceles Right Triangle: More than one side does not match the defined cell size of " + Constants.CELL_SIZE);
            }

            Triangle orderedTriangle = GetOrderedVerticesTriangle(triangle);
            int row = (orderedTriangle.Point1.Y / grid.CellSize);
            string rowLabel = Constants.ROW_LABELS[row].ToString();

            int column = (orderedTriangle.Point3.X / grid.CellSize); // will produce value from 1 to 6.
            int splitColumn = (column * 2);

            // bottom triangle x1 and x2 will be equal so subtracting one for proper placement
            splitColumn = (orderedTriangle.Point1.X == orderedTriangle.Point2.X) ? splitColumn - 1 : splitColumn;

            return rowLabel += splitColumn;
        }

        /// <summary>Gets the distance between points.</summary>
        /// <param name="point1">The point1.</param>
        /// <param name="point2">The point2.</param>
        /// <returns></returns>
        public static double GetDistanceBetweenPoints(Point point1, Point point2)
        {
            //pythagorean theorem c^2 = a^2 + b^2
            //thus c = square root(a^2 + b^2)
            double a = (double)(point2.X - point1.X);
            double b = (double)(point2.Y - point1.Y);

            return Math.Sqrt(a * a + b * b);
        }
        #endregion

        #region private helper methods
        /// <summary>Gets the cell location starting point.</summary>
        /// <param name="grid">The grid.</param>
        /// <param name="cellLocation">The cell location.</param>
        /// <returns></returns>
        private static Point GetCellLocationStartingPoint(Grid grid, string cellLocation)
        {
            int column = (int)Math.Ceiling(float.Parse(cellLocation.Substring(1)) / 2) - 1;
            int rowNumber = char.ToUpper(cellLocation[0]) - 65;
            int x = column * grid.CellSize;
            int y = rowNumber * grid.CellSize;

            return new Point(x, y);
        }

        /// <summary>Gets the ordered vertices for the triangle.</summary>
        /// <param name="triangle">The triangle.</param>
        /// <returns></returns>
        private static Triangle GetOrderedVerticesTriangle(Triangle triangle)
        {
            List<Point> points = new List<Point>() { triangle.Point1, triangle.Point2, triangle.Point3 };

            //sort the triangle points by lowest values to determine upperleft corner of the cell in the grid
            points = new List<Point>(points.OrderBy(point => point.X + point.Y)).ToList();
            return new Triangle(points[0], points[1], points[2]);
        }
        #endregion

    }
}
