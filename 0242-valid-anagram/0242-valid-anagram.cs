public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        int[] count = new int[26]; // for 'a'..'z'

        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;  // increment for char in s
            count[t[i] - 'a']--;  // decrement for char in t
        }

        foreach (int c in count) {
            if (c != 0) {
                return false;
            }
        }

        return true;
    }
}
