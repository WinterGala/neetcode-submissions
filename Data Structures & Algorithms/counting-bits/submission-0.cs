public class Solution {
    public int[] CountBits(int n) {
        int[] output = new int[n + 1];

        for (int i = 0; i <= n; ++i) {
            int count = 0;
            uint val = (uint)i;

            while (val > 0) {
                val &= val - 1;
                ++count;
            }

            output[i] = count;
        }

        return output;
    }
}
