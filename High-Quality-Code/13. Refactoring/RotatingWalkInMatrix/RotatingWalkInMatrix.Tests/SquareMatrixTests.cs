namespace RotatingWalkInMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SquareMatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SquareMatrixWithNegativeSizeShouldThrow()
        {
            SquareMatrix sm = new SquareMatrix(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SquareMatrixWithSizeBiggerThan100ShouldThrow()
        {
            SquareMatrix sm = new SquareMatrix(101);
        }

        [TestMethod]
        public void SquareMatrixRotatingWalkShouldWorkCorrectly()
        {
            SquareMatrix sm = new SquareMatrix(6);
            sm.RotatingWalk();
            int[,] RotatingWalkMatrix= {
                                            { 1, 16, 17, 18, 19, 20 },
                                            { 15, 2, 1, 1, 1, 21},
                                            { 14, 31, 3, 1, 1, 22},
                                            { 13, 1, 1, 4, 1, 23},
                                            { 12, 1, 1, 4, 5, 24},
                                            { 11, 10, 9, 8, 7, 6}
                                       };

            Assert.IsTrue(sm.Equals(RotatingWalkMatrix), "Rotating walk fails when matrix size is 6.");
        }
    }
}
