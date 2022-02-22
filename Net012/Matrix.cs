using System;

namespace Net012
{
    public class Matrix<T>
    {
        public int ColumnsNumber { get; }
        public int RowsNumber { get; }

        public readonly T[] data;

        public Matrix(int col, int row)
        {
            ColumnsNumber = col;
            RowsNumber = row;
            data = new T[col * row];
        }

        public T this[int i, int j]
        {
            set
            {
                if (i >= ColumnsNumber || j >= RowsNumber)
                {
                    throw new ArgumentException("Your indexes i or j are out of Matrix bounds.");
                }
            }
        }
    }
}
