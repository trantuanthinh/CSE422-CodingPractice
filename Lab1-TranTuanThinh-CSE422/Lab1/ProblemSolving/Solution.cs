public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Ensure nums1 is the smaller array
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;

        int low = 0,
            high = m;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = (m + n + 1) / 2 - partitionX;

            // Left and right values for both arrays
            int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int minX = (partitionX == m) ? int.MaxValue : nums1[partitionX];

            int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minY = (partitionY == n) ? int.MaxValue : nums2[partitionY];

            if (maxX <= minY && maxY <= minX)
            {
                // Found the correct partition
                if ((m + n) % 2 == 0)
                {
                    return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                }
                else
                {
                    return Math.Max(maxX, maxY);
                }
            }
            else if (maxX > minY)
            {
                high = partitionX - 1; // Move left
            }
            else
            {
                low = partitionX + 1; // Move right
            }
        }

        throw new ArgumentException("Input arrays are not sorted or invalid.");
    }

    public int Divide(int dividend, int divisor)
    {
        // Handle overflow case
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        // Determine the sign of the result
        bool isNegative = (dividend < 0) ^ (divisor < 0);

        // Work with absolute values
        long absDividend = Math.Abs((long)dividend);
        long absDivisor = Math.Abs((long)divisor);

        // Perform division using subtraction and shifting
        long quotient = 0;
        while (absDividend >= absDivisor)
        {
            long tempDivisor = absDivisor;
            long multiple = 1;

            // Use left shift to find the largest multiple of the divisor
            while (absDividend >= (tempDivisor << 1))
            {
                tempDivisor <<= 1;
                multiple <<= 1;
            }

            absDividend -= tempDivisor;
            quotient += multiple;
        }

        // Apply the sign
        quotient = isNegative ? -quotient : quotient;

        // Clamp the result to the 32-bit signed integer range
        return (int)Math.Min(Math.Max(quotient, int.MinValue), int.MaxValue);
    }

    public bool Exist(char[][] board, string word)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        // Helper function to perform DFS
        bool Dfs(int row, int col, int index)
        {
            // Base case: if all characters in the word are matched
            if (index == word.Length)
            {
                return true;
            }

            // Boundary check and character match validation
            if (row < 0 || row >= rows || col < 0 || col >= cols || board[row][col] != word[index])
            {
                return false;
            }

            // Mark the cell as visited by modifying its value
            char temp = board[row][col];
            board[row][col] = '#';

            // Explore all possible directions (up, down, left, right)
            bool found =
                Dfs(row - 1, col, index + 1)
                || Dfs(row + 1, col, index + 1)
                || Dfs(row, col - 1, index + 1)
                || Dfs(row, col + 1, index + 1);

            // Restore the cell's original value
            board[row][col] = temp;

            return found;
        }

        // Start DFS for each cell in the grid
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (Dfs(i, j, 0))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
