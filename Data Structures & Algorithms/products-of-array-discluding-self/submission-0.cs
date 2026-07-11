public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int sum = 1;
        int[] output = new int[nums.Length];

        for (int i = 0; i < nums.Length; ++i) {
            for (int j = 0; j < nums.Length; ++j)
                if (i == j)
                    continue;
                else
                    sum *= nums[j];

            output[i] = sum;
            sum = 1;
        }
        
        return output;
    }
}
