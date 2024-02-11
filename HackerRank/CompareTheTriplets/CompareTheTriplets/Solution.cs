﻿
class Solution
{
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
      
        var result = new List<int> { 0, 0 };

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                result[0]++;
            }
            else if (a[i] < b[i])
            {
                result[1]++;
            }
        }
        return result;
    }
}



