namespace Net012
{
    public class Index
    {
        private int i;
        private int j;

        public int IndexI
        {
            get => i;
            set => i = value;
        }

        public int IndexJ
        {
            get => j;
            set => j = value;
        }

        public Index(int i, int j)
        {
            IndexI = i;
            IndexJ = j;
        }
    }
}
