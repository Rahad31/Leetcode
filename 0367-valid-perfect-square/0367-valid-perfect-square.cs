public class Solution {
    public bool IsPerfectSquare(int num) {
        int root = (int)Math.Sqrt(num);
        return root * root == num;
    }
}
