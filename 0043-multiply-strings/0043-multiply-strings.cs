public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1 == "0" || num2 == "0") return "0";

        int m = num1.Length, n = num2.Length;
        int[] result = new int[m + n];

        for (int i = m - 1; i >= 0; i--) {
            for (int j = n - 1; j >= 0; j--) {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int sum = mul + result[i + j + 1];
                
                result[i + j + 1] = sum % 10;
                result[i + j] += sum / 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (int num in result) {
            if (!(sb.Length == 0 && num == 0)) {
                sb.Append(num);
            }
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
