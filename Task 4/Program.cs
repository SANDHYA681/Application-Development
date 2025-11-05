

class Program
{
    public static void Main()
    {
        //  Creating a single-dimensional integer array
        int[] favoriteNumbers = { 7, 42, 3, 15, 28 };

        //  Sorting the array in ascending order
        Array.Sort(favoriteNumbers);
        Console.WriteLine("Array after sorting in ascending order:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.Write(favoriteNumbers[i] + " ");
        }
        Console.WriteLine(); // Move to next line

        //  Reversing the sorted array
        Array.Reverse(favoriteNumbers);
        Console.WriteLine("Array after reversing:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.Write(favoriteNumbers[i] + " ");
        }
        Console.WriteLine();

        //  Finding the position of a specific number
        int numberToFind = 15;
        int position = Array.IndexOf(favoriteNumbers, numberToFind);
        if (position != -1)
        {
            Console.WriteLine($"The number {numberToFind} is at index {position} in the array.");
        }
        else
        {
            Console.WriteLine($"The number {numberToFind} was not found in the array.");
        }
    }
}
