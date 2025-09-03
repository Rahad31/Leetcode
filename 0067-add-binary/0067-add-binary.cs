public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder sb = new StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0) {
            int total = carry;

            if (i >= 0) {
                total += a[i] - '0'; // convert char to int
                i--;
            }
            if (j >= 0) {
                total += b[j] - '0';
                j--;
            }

            sb.Append(total % 2);   // add current bit
            carry = total / 2;      // update carry
        }

        // Reverse because we built from LSB to MSB
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
