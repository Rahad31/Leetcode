public class Solution {
    public string ConvertToBase7(int num) {
        if (num == 0) return "0";

        bool isNegative = num < 0;
        num = Math.Abs(num);

        StringBuilder sb = new StringBuilder();
        while (num > 0) {
            sb.Insert(0, (num % 7).ToString());
            num /= 7;
        }

        return isNegative ? "-" + sb.ToString() : sb.ToString();
    }
}
