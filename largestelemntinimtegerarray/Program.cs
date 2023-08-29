using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 7 };
        int largest = array[0];

        foreach (int num in array)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine("Largest element in the array: " + largest);
    }
}
