class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        // Problem 1: Find Median of Two Sorted Arrays
        HandleFindMedian(solution);

        // Problem 2: Divide Two Integers
        HandleIntegerDivision(solution);

        // Problem 3: Word Search in Grid
        HandleWordSearch(solution);
    }

    private static void HandleFindMedian(Solution solution)
    {
        Console.WriteLine("=== Find Median of Two Sorted Arrays ===");

        Console.Write("Enter the elements of the first array (space-separated): ");
        int[] nums1 = ReadArrayInput();

        Console.Write("Enter the elements of the second array (space-separated): ");
        int[] nums2 = ReadArrayInput();

        double median = solution.FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine($"Median: {median:F2}");
    }

    private static void HandleIntegerDivision(Solution solution)
    {
        Console.WriteLine("\n=== Divide Two Integers ===");

        Console.Write("Enter dividend: ");
        int dividend = int.Parse(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        try
        {
            int result = solution.Divide(dividend, divisor);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static void HandleWordSearch(Solution solution)
    {
        Console.WriteLine("\n=== Word Search in Grid ===");

        char[][] board = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' },
        };

        string[] words = { "ABCCED", "SEE", "ABCB" };

        foreach (string word in words)
        {
            bool exists = solution.Exist(board, word);
            Console.WriteLine($"Word '{word}' exists in board: {exists}");
        }
    }

    private static int[] ReadArrayInput()
    {
        return Console
            .ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
