namespace Net012
{
    public class SquareMatrix : BaseMatrix
    {
        public SquareMatrix(int matrixSize, Index indexOne, Index indexTwo, Index indexThree,
                            Index indexFour, Index indexFive, Index indexSix,
                            Index indexSeven, Index indexEight, Index indexNine)
        {
            baseMatrixSize = matrixSize;
            IJ1 = indexOne;
            IJ2 = indexTwo;
            IJ3 = indexThree;
            IJ4 = indexFour;
            IJ5 = indexFive;
            IJ6 = indexSix;
            IJ7 = indexSeven;
            IJ8 = indexEight;
            IJ9 = indexNine;
        }

        // Make a check if given indexes can create a
        // square matrix: n x n
    }
}
