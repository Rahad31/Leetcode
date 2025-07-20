public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) return false;
        int x2=x, length=0,conv=0;
        while(x2>=1){
            length++; x2/=10;
        }
        x2=x;
        while(x2>=1){
            length--;
            conv+=(x2%10)*(int)Math.Pow(10,length);
            x2/=10;
        }
        if (x==conv) return true;
        else return false;
    }
}