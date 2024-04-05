using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        public static int[] array2;
        public static int[] array3 = new int[0];

        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 4, 1, 4, 2, 9, 5, 5, 5, 5, 5, 10};

            array = ArrayOperations.InsertLast(array3,10);

            foreach (var element in array)
            {
                Console.Write (element+" "  );
            }

        }
    }
}
