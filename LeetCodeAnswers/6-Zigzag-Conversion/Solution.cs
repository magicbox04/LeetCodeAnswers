namespace LeetCodeAnswers._6_Zigzag_Conversion;
using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        StringBuilder[] rows = new StringBuilder[numRows];       
        for (int i = 0; i < numRows; i++)  {
            rows[i] = new StringBuilder();
        }

        int curRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            rows[curRow].Append(c);
            if (curRow == 0 || curRow == numRows - 1)
            {
                goingDown = !goingDown;
            }
            curRow += goingDown ? 1 : -1;
        }
        
        StringBuilder result = new StringBuilder();

        foreach (var row in rows)
        {
            result.Append(row);
        }
        return result.ToString();
    }
}