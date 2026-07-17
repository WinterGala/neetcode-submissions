public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int l = nums.Length;
        int[] arr = new int[l * 2];

        for (int i = 0; i < l; ++i) {
            arr[i] = nums[i];
            arr[i + l] = nums[i];
        }

        return arr;
    }
}