public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = Regex.Replace(s, "[^A-Za-z0-9]+", "");

        for (int i = 0; i < s.Length / 2; ++i)
            if ((int)(s[i] ^ s[^(i + 1)]) != 0)
                return false;

        return true;
    }
}
