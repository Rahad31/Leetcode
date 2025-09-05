public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int total = n * (n + 1) / 2;
        int sum = 0;
        
        foreach (int num in nums) {
            sum += num;
        }
        
        return total - sum;
    }
}
