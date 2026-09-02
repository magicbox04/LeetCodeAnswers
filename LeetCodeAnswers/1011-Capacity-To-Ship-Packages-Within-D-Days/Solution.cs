namespace LeetCodeAnswers._1011_Capacity_To_Ship_Packages_Within_D_Days;

// https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/description/

public class Solution {
    public int ShipWithinDays(int[] weights, int days)
    {
        int left = weights.Max();
        int right = 0;

        foreach (int weight in weights)
        {
            right += weight;
        }

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (canShip(weights, mid, days))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    bool canShip(int[] weights, int mid, int days)
    {
        long totalDay = 0;
        int totalWeightPerDay = mid;
        for (int i = 0; i <  weights.Length; i++)
        {
            if (totalWeightPerDay >= weights[i])
            {
                totalWeightPerDay -= weights[i];
            }
            else
            {
                totalDay++;
                totalWeightPerDay = mid;
                i--;
            }
        }

        totalDay++;
        return (totalDay <= days);
    }
}