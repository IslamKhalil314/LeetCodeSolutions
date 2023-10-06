public class Solution {
    public int Reverse(int x) {
     bool isNeg = x < 0;
    if (isNeg) x = x * -1;
    decimal res = 0;
    while (x != 0)
    {
        res = (res * 10) + (x % 10);
        x /= 10;
    }
    if (!int.TryParse(res.ToString(), out int y))
        return 0;
    return isNeg ? -y : y;
    }
}
