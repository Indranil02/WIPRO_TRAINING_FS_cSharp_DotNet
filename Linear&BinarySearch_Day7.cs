using System;
using System.Diagnostics;
using System.Linq;

 class SearchComparison
{
    // Step 1: Linear Search Method
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    // Step 1: Binary Search Method
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        // Step 2: Take input for array size and elements
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Binary search requires a sorted array
        Array.Sort(arr);
        Console.WriteLine("\nSorted Array: " + string.Join(", ", arr));

        Console.Write("Enter the element to search for: ");
        int target = int.Parse(Console.ReadLine());

        // Call methods and measure time using Stopwatch
        Stopwatch sw = new Stopwatch();

        // Linear Search Execution
        sw.Start();
        int linearIndex = LinearSearch(arr, target);
        sw.Stop();
        double linearMs = sw.Elapsed.TotalMilliseconds;

        sw.Reset();

        // Binary Search Execution
        sw.Start();
        int binaryIndex = BinarySearch(arr, target);
        sw.Stop();
        double binaryMs = sw.Elapsed.TotalMilliseconds;

        // Step 4: Display Results
        Console.WriteLine($"Linear Search: Index {linearIndex} | Time: {linearMs:F4} ms");
        Console.WriteLine($"Binary Search: Index {binaryIndex} | Time: {binaryMs:F4} ms");
    }
}