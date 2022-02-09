using System;

namespace Net012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET01.2 Generics, delegates and events");

            var squareMatrixOneSize = 9;
            var indexOneOne = new Index(0, 0);
            var indexOneTwo = new Index(0, 1);
            var indexOneThree = new Index(0, 2);
            var indexTwoOne = new Index(1, 0);
            var indexTwoTwo = new Index(1, 1);
            var indexTwoThree = new Index(1, 2);
            var indexThreeOne = new Index(2, 0);
            var indexThreeTwo = new Index(2, 1);
            var indexThreeThree = new Index(2, 2);

            var squareMatrixOne = new SquareMatrix(squareMatrixOneSize,
                                                   indexOneOne, indexOneTwo, indexOneThree,
                                                   indexTwoOne, indexTwoTwo, indexTwoThree,
                                                   indexThreeOne, indexThreeTwo, indexThreeThree);



            int[] array = new int[9];
            array[0] = 11;
            array[1] = 12;
            array[2] = 13;
            array[3] = 21;
            array[4] = 22;
            array[5] = 23;
            array[6] = 31;
            array[7] = 32;
            array[8] = 33;
        }


    }
}
