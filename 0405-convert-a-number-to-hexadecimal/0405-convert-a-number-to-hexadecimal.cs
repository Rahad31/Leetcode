public class Solution {
    public string ToHex(int num) {
        if (num == 0) return "0";
        const string hexChars = "0123456789abcdef";
        uint n = (uint) num;            // treat bits as unsigned
        var sb = new System.Text.StringBuilder();
        while (n != 0) {
            uint digit = n & 0xFu;     // last 4 bits
            sb.Append(hexChars[(int)digit]);
            n >>= 4;
        }
        // characters appended in reverse order
        var arr = sb.ToString().ToCharArray();
        System.Array.Reverse(arr);
        return new string(arr);
    }
}
