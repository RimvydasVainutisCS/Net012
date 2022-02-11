using System;

namespace Net012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NET01.2 Generics, delegates and events");

            var squareMatrixOne = new SquareMatrix(2);

            squareMatrixOne.SetIndex(0, 0, 1);
            squareMatrixOne.SetIndex(0, 1, 2);
            squareMatrixOne.SetIndex(1, 0, 3);
            squareMatrixOne.SetIndex(1, 1, 5);
            Console.WriteLine(squareMatrixOne.GetIndex(0, 0));
            Console.WriteLine(squareMatrixOne.GetIndex(0, 1));
            Console.WriteLine(squareMatrixOne.GetIndex(1, 0));
            Console.WriteLine(squareMatrixOne.GetIndex(1, 1));

            Console.WriteLine();
            Console.WriteLine(squareMatrixOne.GetMatrixIndex(0, 0));
            Console.WriteLine(squareMatrixOne.GetMatrixIndex(0, 1));
            Console.WriteLine(squareMatrixOne.GetMatrixIndex(1, 0));
            Console.WriteLine(squareMatrixOne.GetMatrixIndex(1, 1));

            var squareMatrixTwo = new SquareMatrixGeneric<string>(2);
            squareMatrixTwo[0, 0] = "one";
            squareMatrixTwo[0, 1] = "two";
            squareMatrixTwo[1, 0] = "three";
            squareMatrixTwo[1, 1] = "four";

            Console.WriteLine();
            Console.WriteLine(squareMatrixTwo[0, 0]);
            Console.WriteLine(squareMatrixTwo[0, 1]);
            Console.WriteLine(squareMatrixTwo[1, 0]);
            Console.WriteLine(squareMatrixTwo[1, 1]);
        }
    }
}
