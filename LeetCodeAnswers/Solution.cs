using System.Data;

namespace LeetCodeAnswers;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;
        
        int [] s1Freq = new int[26];
        foreach (char c in s1)
        {
            s1Freq[c - 'a']++;
        }

        int left = 0;
        int right = s1.Length;
        int [] s2SubStringFreq = new int[26];
        foreach (char c in s2[left..right])
        {
            s2SubStringFreq[c - 'a']++;
        }
        
        while (right <= s2.Length)
        {
            if (s1Freq.SequenceEqual( s2SubStringFreq))
            {
                return true;
            }

            s2SubStringFreq[s2[left] - 'a']--;
            left++;
            right++;
            if (right <= s2.Length)
                s2SubStringFreq[s2[right-1] - 'a']++;

        }

        return false;
    }
    
}

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        int[] nums = [1,2,3,4,5,6,7,8,9,10];
        int[][] matrix = [[1]]; 
        String s1 = "adc";
        String s2 = "dcda";
        List<string> strs = new List<string>(["Hello","World"]);
        
        
        Console.WriteLine(sol.CheckInclusion(s1, s2));
    }
}