public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        if (ops.Length == 0) return m * n;
        
        int minRow = m;
        int minCol = n;
        
        foreach (var op in ops) {
            minRow = Math.Min(minRow, op[0]);
            minCol = Math.Min(minCol, op[1]);
        }
        
        return minRow * minCol;
    }
}
