using System;
class Program
{
    public static int sumElements(int[] array)
    {
        int sumArrElements = 0;
        foreach (int i in array)
        {
            if (i % 2 == 0)
            {
                sumArrElements += i;
            }
        }
        return sumArrElements;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        int solution = sumElements(arr);
        Console.WriteLine("The sum of even elements in the array is " + solution);
    }
}
