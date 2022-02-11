namespace Net012
{
    public class SquareMatrixGeneric<T> where T : class
    {
        readonly int _rank = 0;
        public T[] Matrix2;

        public SquareMatrixGeneric(int rank)
        {
            _rank = rank;
            Matrix2 = new T[_rank * _rank];
        }

        public T this[int i, int j]
        {
            get { return Matrix2[(i * _rank) + j]; }
            set { Matrix2[(i * _rank) + j] = value; }
        }
    }
}
