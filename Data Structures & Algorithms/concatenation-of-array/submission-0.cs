public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] arr = new int[nums.Length * 2];

        Array.Copy(nums, 0, arr, 0, nums.Length);
        Array.Copy(nums, 0, arr, nums.Length, nums.Length);

        return arr;
    }
}