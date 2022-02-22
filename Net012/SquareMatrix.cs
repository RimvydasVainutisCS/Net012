using System;

namespace Net012
{
    public class SquareMatrix
    {
        public delegate void MatrixElementChange(CustomEventArgs e);

        public class CustomEventArgs : EventArgs
        {
            public CustomEventArgs(int[] matrix)
            {
                Matrix = matrix;
            }
            public int[] Matrix { get; }
        }

        //public event EventHandler<CustomEventArgs> OnMatrixElementChange;

        readonly int _rank = 0;

        public int[] Matrix { get; set;}

        public SquareMatrix(int rank)
        {
            _rank = rank;
            if (rank <= 0)
            {
                throw new ArgumentException("Matrix Rank has to be positive integer.");
            }
            else
            {
                Matrix = new int[_rank * _rank];
            }
        }

        public int GetIndex(int i, int j)
        {
            if (i <= _rank - 1 && j <= _rank - 1)
            {
                return Matrix[(i * _rank) + j];
            }
            else
            {
                throw new IndexOutOfRangeException("Your indicies are out of Matrix bounds.");
            }
        }

        public void SetIndex(int i, int j, int value)
        {
            Matrix[(i * _rank) + j] = value;
        }

        public int GetMatrixArrayIndex(int i, int j)
        {
            return (i * _rank) + j;
        }
    }
}
