using Figures;
using Figures.Exceptions;

namespace TestTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleSquare()
        {
            //Arrange
            Figure circle1 = new Circle(20);


            const double RES = 2513.3;
            //Act
            
            double square = circle1.Square();
            square = Math.Round(square, 1);
            //Assert
            Assert.AreEqual(square, RES);
            
        }
        [TestMethod]
        public void TestTriangleSquare()
        {
            Figure triangle = new Triangle(1,2,2);
            const double RES = 1;
            //Act

            double square = triangle.Square();
            square = Math.Round(square, 1);


            //Assert
            Assert.AreEqual(square, RES);
        }
        [TestMethod]
        public void TestZeroValueCircleException()
        {
            //Arrange
            
            Figure circle2;
            
            bool isException = false;
            
            //Act
            try
            {
                circle2 = new Circle(0);
            }
            catch (Exception ex)
            {
                isException = ex is ZeroValueException;
            }

            //Assert
            
            Assert.IsTrue(isException);
        }
        [TestMethod]
        public void TestIsRectangular()
        {
            //Arrange
            IRectangular figure = new Triangle(3, 4, 5);

            //Act
            var isRectangular = figure.IsRectangular();

            //Assert
            Assert.IsTrue(isRectangular);
        }
        [TestMethod]
        public void TestZeroValueTriangleException()
        {
            //Arrange

            Figure triangle;

            bool isException = false;

            //Act
            try
            {
                triangle = new Triangle(0, 1, 0);
            }
            catch (Exception ex)
            {
                isException = ex is ZeroValueException;
            }

            //Assert

            Assert.IsTrue(isException);
        }
        [TestMethod]
        public void TestNotExistsTriangleException()
        {
            //Arrange

            Figure triangle;

            bool isException = false;

            //Act
            try
            {
                triangle = new Triangle(1, 2, 3);
            }
            catch (Exception ex)
            {
                isException = ex is FigureNotExistsException;
            }

            //Assert

            Assert.IsTrue(isException);
        }
    }
    
}