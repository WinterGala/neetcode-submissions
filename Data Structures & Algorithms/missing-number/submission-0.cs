public class Solution {
    public int MissingNumber(int[] nums) {
        int targetSum = (nums.Length * (nums.Length + 1)) / 2;
        int sum = 0;

        foreach (var n in nums)
            sum += n;

        return targetSum - sum;
    }
}
