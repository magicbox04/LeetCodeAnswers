namespace LeetCodeAnswers._36_Valid_Sudoku;
// https://leetcode.com/problems/valid-sudoku/description/
public class Solution
{
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> horizontal = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> vertical  = new Dictionary<int, HashSet<char>>();
        Dictionary<String, HashSet<char>> box = new Dictionary<String, HashSet<char>>();

        for (int i = 0; i < 9; i++)
        {
            if (!horizontal.ContainsKey(i))
            {
                horizontal[i] = new HashSet<char>();
            }
                
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                
                String boxIndex = i / 3 + "," + j / 3;
                
                if (!vertical.ContainsKey(j))
                {
                    vertical[j] = new HashSet<char>();
                }
                
                if (!box.ContainsKey(boxIndex))
                {
                    box[boxIndex] = new HashSet<char>();
                }
                
                if (horizontal[i].Contains(board[i][j]) || vertical[j].Contains(board[i][j]) || box[boxIndex].Contains(board[i][j]))
                {
                    return false;
                }
                horizontal[i].Add(board[i][j]);
                vertical[j].Add(board[i][j]);
                box[boxIndex].Add(board[i][j]);
            }
        }

        return true;
    }
}