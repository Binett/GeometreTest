using Geometri.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        [DataRow(1f, 3.14f)]
        public void AreaTest01_CalculateTheAreaByRadius_ReturnsArea
            (float radius, float expected)
        {
            //Arrange
            var circle = new Circle(radius);
            //Act
            var actual = circle.Area();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(null, 0)]
        public void AreaTest02_CalculateWithNegativeValueAndNull_ReturnsZero
            (float radius, float expected)
        {
            //Arrange
            var circle = new Circle(radius);
            //Act
            var actual = circle.Area();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(2f, 12.57f)]
        public void PerimeterTest01_CalculatePerimeterByRadius_ReturnPerimeter
            (float radius, float expected)
        {
            //Arrange
            var circle = new Circle(radius);
            //Act
            var actual = circle.Perimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(-1f, 0)]
        public void PerimeterTest02_CalculateWithNegativeValueAndNull_returnsZero(
            float radius, float expected)
        {
            //Arrange
            var circle = new Circle(radius);
            //Act
            var actual = circle.Perimeter();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
