using System;

namespace C_ArraysCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_one;
            array_one = new int[10];

            string[] array_two = new string[5];

            short[] array_three = new short[5] { 1, 2, -2, 5, 10};

            long[] longs = { 830948902849023993L, 2313239492349232344L, 239084823892348234L};

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(12, 0);

            //Console.WriteLine(myArray2[0]);
            Console.WriteLine(myArray2.GetValue(0));
            Console.WriteLine();

            int[] numbers = { 9, 7, 5, 2, 4, 1, 0, 3, 6, 8};
            Console.WriteLine(string.Join(" ", numbers));
            Array.Sort(numbers); // { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
            Console.WriteLine(string.Join(" ", numbers));

            int index = Array.BinarySearch(numbers, 7); //работает только на упорядоченном массиве
            Console.WriteLine(index);
            Console.WriteLine();

            int[] copyOfNumbers = new int[numbers.Length];
            Array.Copy(numbers, copyOfNumbers, numbers.Length);

            Console.WriteLine();
            Console.WriteLine(copyOfNumbers.ToString);

            string numbersAsString = string.Join(", ", numbers);
            Console.WriteLine("Array numbers: " + numbersAsString);
            string copyOfNumbersAsString = string.Join(", ", copyOfNumbers);
            Console.WriteLine($"Array copyOfNumbers {copyOfNumbersAsString}");

        }
    }
}