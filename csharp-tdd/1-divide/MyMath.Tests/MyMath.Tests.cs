using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsNewDividedMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 12, 16 } };
            int[,] result = Matrix.Divide(matrix, 2);
            int[,] expected = { { 2, 4 }, { 6, 8 } };
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,]? result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_DivideByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 4, 8 } };
            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,]? result = Matrix.Divide(matrix, 0);
                
                Assert.IsNull(result);
                Assert.AreEqual("Num cannot be 0", sw.ToString().Trim());
            }
        }

        [Test]
        public void Divide_SingleElement_ReturnsCorrectResult()
        {
            int[,] matrix = { { 10 } };
            int[,] result = Matrix.Divide(matrix, 5);
            int[,] expected = { { 2 } };
            
            Assert.AreEqual(expected, result);
        }
    }
}