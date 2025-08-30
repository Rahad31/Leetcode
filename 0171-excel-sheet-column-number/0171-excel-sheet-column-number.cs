public class Solution {
    public int TitleToNumber(string columnTitle) {
              int result = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            // Convert current character to number
            int num = columnTitle[i] - 'A' + 1;
            
            // Multiply previous result by 26 and add current
            result = result * 26 + num;
        }
        return result;
        
    }
}