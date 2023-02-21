using System;

namespace HW3
{
    class HW3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength = Int32.Parse(Console.ReadLine());

            int[] arr = new int[arrayLength];

            for(int i = 0; i < arrayLength; i++) 
            { 
                Console.Write("Enter number for arr[" + i + "]: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int[] reverse = reverseArr(arr);


            Console.WriteLine("Sum of array: " + sumArr(arr));
            Console.WriteLine("Product of array: " + multArr(arr));

            Console.Write("Array in reverse: ");
            // Prints reverse
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(reverse[i] + " ");
            }

            Console.ReadKey();
        }

        // Adds all the indexes of the array
        static int sumArr(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        // Multiplies all the indexes of the array
        static int multArr(int[] arr)
        {
            int product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }

            return product;
        }

        // Reverse the inputted array
        static int[] reverseArr(int[] arr)
        {
            int[] reverse = new int[arr.Length];
            int x = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reverse[x] = arr[i];
                x++;
            }

            return reverse;
        }
    }
}
