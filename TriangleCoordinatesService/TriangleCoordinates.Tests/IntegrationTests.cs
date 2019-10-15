using NUnit.Framework;
using System.Drawing;
using TriangleCoordinates.Lib;
using TriangleCoordinates.Util;

namespace TriangleCoordinates.Tests
{
    public class IntegrationTests
    {
        private Grid _grid;

        [SetUp]
        public void Setup()
        {
            _grid = new Grid(Constants.ROW_COUNT, Constants.COLUMN_COUNT, Constants.CELL_SIZE);
        }

        [Test]
        public void ShouldGetTriangleVerticesForCellLocationA1()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = Calculations.GetTriangleFromCellLocation(_grid, "A1");

            //Assert
            Assert.IsTrue(triangle.Point1.X == 0 && triangle.Point1.Y == 0);
            Assert.IsTrue(triangle.Point2.X == 0 && triangle.Point2.Y == 10);
            Assert.IsTrue(triangle.Point3.X == 10 && triangle.Point3.Y == 10);
        }

        [Test]
        public void ShouldGetTriangleVerticesForCellLocationD6()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = Calculations.GetTriangleFromCellLocation(_grid, "D6");

            //Assert
            Assert.IsTrue(triangle.Point1.X == 20 && triangle.Point1.Y == 30);
            Assert.IsTrue(triangle.Point2.X == 30 && triangle.Point2.Y == 30);
            Assert.IsTrue(triangle.Point3.X == 30 && triangle.Point3.Y == 40);
        }

        [Test]
        public void ShouldGetTriangleVerticesForCellLocationF12()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = Calculations.GetTriangleFromCellLocation(_grid, "F12");

            //Assert
            Assert.IsTrue(triangle.Point1.X == 50 && triangle.Point1.Y == 50);
            Assert.IsTrue(triangle.Point2.X == 60 && triangle.Point2.Y == 50);
            Assert.IsTrue(triangle.Point3.X == 60 && triangle.Point3.Y == 60);
        }

        [Test]
        public void ShouldGetCellLocationA1ForTriangleVertices()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 10));
            string result = Calculations.GetCellLocationFromTriangle(_grid, triangle);

            //Assert
            Assert.AreEqual("A1", result);
        }

        [Test]
        public void ShouldGetCellLocationD6ForTriangleVertices()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle(new Point(20, 30), new Point(30, 30), new Point(30, 40));
            string result = Calculations.GetCellLocationFromTriangle(_grid, triangle);

            //Assert
            Assert.AreEqual("D6", result);
        }

        [Test]
        public void ShouldGetCellLocationF12ForTriangleVertices()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle(new Point(50, 50), new Point(60, 50), new Point(60, 60));
            string result = Calculations.GetCellLocationFromTriangle(_grid, triangle);

            //Assert
            Assert.AreEqual("F12", result);
        }
    }
}
