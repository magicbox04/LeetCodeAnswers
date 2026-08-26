namespace LeetCodeAnswers._875_Koko_Eating_Bananas;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int answer = right;
        
        while(left <= right)
        {
            int midpoint = (left + right) / 2;

            if (CanFinish(piles, h, midpoint))
            {
                answer = midpoint;
                right = midpoint - 1;
            }
            else
            {
                left = midpoint + 1;
            }
        }

        return answer;
    }

    private bool CanFinish(int[] piles, int h, int midpoint)
    {
        int hours = 0;
        foreach (int pile in piles)
        {
            hours += (pile + midpoint - 1) / midpoint;
        }

        return hours <= h;
    }
}