namespace Net012
{
    public class SquareMatrix
    {
        readonly int _rank = 0;
        public int[] Matrix { get; set; }

        public SquareMatrix(int rank)
        {
            _rank = rank;
            Matrix = new int[_rank * _rank];
        }

        public int GetIndex(int i, int j)
        {
            return Matrix[(i * _rank) + j];
        }

        public void SetIndex(int i, int j, int value)
        {
            Matrix[(i * _rank) + j] = value;
        }

        public int GetMatrixIndex(int i, int j)
        {
            return (i * _rank) + j;
        }
    }
}
