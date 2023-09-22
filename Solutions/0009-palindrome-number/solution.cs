public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        int i = 10;
        int res = 0;
        int remainder = x;
        while(remainder > 0){
            
            res = (res*10) + (remainder % i);
            remainder = remainder / i;
        }
        return x == res;
    }
}
