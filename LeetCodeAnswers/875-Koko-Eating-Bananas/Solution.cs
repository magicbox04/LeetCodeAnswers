namespace LeetCodeAnswers._875_Koko_Eating_Bananas;

public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();

        while (left < right)
        {
            int midPoint = left + (right - left) / 2;
            if (canEat(piles, h, midPoint))
            {
                right = midPoint;
            }
            else
            {
                left = midPoint + 1;
            }
        }

        return left;
    }

    public bool canEat(int[] piles, int expectedDay, int eatingSpeed)
    {
        int days = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            days += (piles[i] + eatingSpeed - 1) / eatingSpeed;
        }

        return days <= expectedDay;
    }
}