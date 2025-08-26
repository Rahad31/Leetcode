using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> values = new Dictionary<char, int>() {
            {'I', 1}, {'V', 5}, {'X', 10},
            {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int total = 0;
        for (int i = 0; i < s.Length; i++) {
            // If next value is bigger, subtract current
            if (i + 1 < s.Length && values[s[i]] < values[s[i + 1]]) {
                total -= values[s[i]];
            } else {
                total += values[s[i]];
            }
        }
        return total;
    }
}
