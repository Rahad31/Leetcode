public class Solution {
    public string ConvertToTitle(int columnNumber) {
         string result = "";
        while (columnNumber > 0)
        {
            columnNumber--; 
            int remainder = columnNumber % 26;
            char letter = (char)(remainder + 'A');
            result = letter + result; 
            columnNumber /= 26;
        }
        return result;
    }
}