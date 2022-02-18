using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net012
{
    public class Matrix<T>
    {
        public int RowsNumber { get; }
        public int ColumnsNumber { get; }

        private readonly T[] data;

        public Matrix (int col, int row)
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
