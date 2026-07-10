public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int len = s.Length;
        int res = 0;
        Dictionary<char, int> dict = new();
        
        foreach (var c in s) {
            dict.TryAdd(c, 0);
            dict[c]++;
        }
        
        foreach (var c in t) {
            dict.TryAdd(c, 0);
            dict[c]--;
        }

        foreach (var pair in dict)
            res |= pair.Value;

        return res == 0;
    }
}
