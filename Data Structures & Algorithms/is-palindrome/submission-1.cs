public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = Regex.Replace(s, "[^A-Za-z0-9]+", "");
        int res = 0;

        for (int i = 0; i < s.Length / 2; ++i)
            res += (int)(s[i] ^ s[^(i + 1)]);

        return res == 0;
    }
}
