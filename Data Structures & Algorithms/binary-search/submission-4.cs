public class Solution {
    public int Search(int[] nums, int target) {
        int lo = 0;
        int hi = nums.Length - 1;

        while (lo <= hi) {
            int mid = ((hi - lo) / 2) + lo;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                hi = mid - 1;
            else
                lo = mid + 1;
        }

        return -1;
    }
}
