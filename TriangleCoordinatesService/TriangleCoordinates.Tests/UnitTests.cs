using NUnit.Framework;
using System.Drawing;
using TriangleCoordinates.Lib;
using TriangleCoordinates.Util;

namespace TriangleCoordinates.Tests
{
    public class UnitTests
    {
        private Grid _grid;

        [SetUp]
        public void Setup()
        {
            _grid = new Grid(Constants.ROW_COUNT, Constants.COLUMN_COUNT, Constants.CELL_SIZE);
        }

        [Test]
        public void ShouldValidateTrianglePointsInGrid()
        {
            //Arrange
            Triangle triangle;
            bool success;

            //Act
            triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 10));
            success = Validations.ValidateTrianglePointsInGrid(_grid, triangle);

            //Assert
            Assert.IsTrue(success);
        }

        [Test]
        public void ShouldValidateTrianglePointsNotInGrid()
        {
            //Arrange
            Triangle triangle;
            bool success;

            //Act
            triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 70));
            success = Validations.ValidateTrianglePointsInGrid(_grid, triangle);

            //Assert
            Assert.IsTrue(!success);
        }

        [Test]
        public void ShouldValidateIsIsoscelesRightTriangle()
        {
            //Arrange
            Triangle triangle;
            bool success;

            //Act
            triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 10));
            success = Validations.ValidateIsIsoscelesRightTriangle(triangle);

            //Assert
            Assert.IsTrue(success);
        }

        [Test]
        public void ShouldValidateIsNotIsoscelesRightTriangle()
        {
            //Arrange
            Triangle triangle;
            bool success;

            //Act
            triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 70));
            success = Validations.ValidateIsIsoscelesRightTriangle(triangle);

            //Assert
            Assert.IsTrue(!success);
        }

        [Test]
        public void ShouldValidateCellLocationInGrid()
        {
            //Arrange
            bool success;

            //Act
            success = Validations.ValidateCellLocationInGrid("C7");

            //Assert
            Assert.IsTrue(success);
        }

        [Test]
        public void ShouldValidateCellLocationNotInGrid()
        {
            //Arrange
            bool success;

            //Act
            success = Validations.ValidateCellLocationInGrid("E13");

            //Assert
            Assert.IsTrue(!success);
        }
    }
}