public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int l = nums.Length;
        int[] res = new int[l];
        Array.Fill(res, 1);
        int post = 1;
        int pre = 1;

        for (int i = 1; i < l; ++i) {
            res[i] = pre * nums[i - 1];
            pre *= nums[i - 1];
        }

        for (int i = l - 1; i >= 0; --i) {
            res[i] *= post;
            post *= nums[i];
        }

        return res;
    }
}