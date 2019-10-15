using System;
using System.Drawing;


/// <summary>
/// Library classes for TriangleCoordinates
/// </summary>
namespace TriangleCoordinates.Lib
{
    /// <summary>Class Triangle encapsulates methods/properties for defining a triangle.</summary>
    public class Triangle
    {
        #region private properties
        private Point _point1;
        private Point _point2;
        private Point _point3;
        #endregion

        /// <summary>Initializes a new instance of the <see cref="Triangle"/> class.</summary>
        /// <param name="point1">First vertices point.</param>
        /// <param name="point2">Second vertices point.</param>
        /// <param name="point3">Third vertices point.</param>
        public Triangle(Point point1, Point point2, Point point3)
        {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
        }

        #region public getter methods
        /// <summary>Gets the value for private member _point1.</summary>
        /// <value>The first point vertices.</value>
        public Point Point1
        {
            get { return _point1; }
        }

        /// <summary>Gets the value for private member _point3.</summary>
        /// <value>The second point vertices.</value>
        public Point Point2
        {
            get { return _point2; }
        }

        /// <summary>Gets the value for private member _point1.</summary>
        /// <value>The third point vertices.</value>
        public Point Point3
        {
            get { return _point3; }
        }
        #endregion
    }
}
