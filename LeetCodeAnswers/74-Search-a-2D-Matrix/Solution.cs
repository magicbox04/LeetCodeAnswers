namespace LeetCodeAnswers._74_Search_a_2D_Matrix;
// https://leetcode.com/problems/search-a-2d-matrix/
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int leftFirst = 0;
        int rightFirst = matrix.Length - 1;
        int searchMatrixIndex = 0;
        int leftSecond = 0;
        int rightSecond = matrix[0].Length - 1;
        while (leftFirst <= rightFirst)
        {
            int midpoint = leftFirst + (rightFirst - leftFirst) / 2;
            if (matrix[midpoint][0] <= target && matrix[midpoint][matrix[midpoint].Length - 1] >= target)
            {
                searchMatrixIndex = midpoint;
                break;
            }
            else if (matrix[midpoint][matrix[midpoint].Length - 1] < target)
            {
                leftFirst = midpoint + 1;
            }
            else
            {
                rightFirst = midpoint - 1;
            }
        }

        while (leftSecond <= rightSecond)
        {
            int midpoint = leftSecond + (rightSecond - leftSecond) / 2;
            if (matrix[searchMatrixIndex][midpoint] == target)
            {
                return true;
            }
            else if (matrix[searchMatrixIndex][midpoint] < target)
            {
                leftSecond = midpoint + 1;
            }
            else
            {
                rightSecond = midpoint - 1;
            }
        }

        return false;
    }
}