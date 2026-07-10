public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> h = new();
        bool res;

        foreach (int n in nums) {
            res = h.Add(n);

            if (res == false)
                return true;
        }

        return false;
    }
}