public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> result = new();

        foreach (int num in nums)
        {
            if (!result.ContainsKey(num))
            {
                result[num] = 0;
            }
            result[num]++;
        }
        var topN = result.OrderByDescending(x => x.Value).Take(k).Select(pair => pair.Key).ToArray();

        return topN;
    }
}