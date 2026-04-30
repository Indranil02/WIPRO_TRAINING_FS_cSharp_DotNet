// bubble sort theory
// here we compare adjacent positions, and if the element on left is bigger it swaps
// we create two loops, i loop for how many times the process will work and j loop for scanning

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bubble Sort");
        
        // 1. Get User Input
        Console.Write("Enter numbers separated by spaces ");
        string input = Console.ReadLine();
        
        // Convert the string input into an integer array
        string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = Array.ConvertAll(inputParts, int.Parse);

        Console.WriteLine("\nSorting...");
        BubbleSort(numbers);

        // 2. Output the Result
        Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        // Outer loop for each pass
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            // Inner loop for comparisons
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the array is sorted
            if (!swapped) break;
        }
    }
}
