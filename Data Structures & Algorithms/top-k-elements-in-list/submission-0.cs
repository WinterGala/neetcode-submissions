public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();
        int[] output = new int[k];

        foreach (var n in nums) {
            dict.TryAdd(n, 0);
            dict[n]++;
        }

        output = dict
            .OrderByDescending(v => v.Value)
            .Take(k)
            .Select(p => p.Key)
            .ToArray();
        
        return output;
    }
}
