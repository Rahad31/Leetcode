public class Solution {
    public char FindTheDifference(string s, string t) {
        int res = 0;
        
        foreach (char c in s) {
            res ^= c;   // XOR all chars from s
        }
        foreach (char c in t) {
            res ^= c;   // XOR all chars from t
        }
        
        return (char)res;
    }
}
