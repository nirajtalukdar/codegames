using System;
namespace codegames
{
    public class FibonacciSequence
    {

        private static int[] FibArray = null;


        private int findFibonacci(int n)
        {

            if (FibArray[n] != -1)
            {
                return FibArray[n];
            }
           
            FibArray[n] = findFibonacci(n - 1) + findFibonacci(n - 2);
            return FibArray[n];
        }

        public static void Main(string[] args)
        {

            FibArray = new int[11];
            for (int i = 0; i < FibArray.Length; i++)
            {
                FibArray[i] = -1;
            }
            FibArray[0] = 0;
            FibArray[1] = 1;

            FibonacciSequence fSeq = new FibonacciSequence();
            Console.WriteLine(fSeq.findFibonacci(6));
        }

    }
}
