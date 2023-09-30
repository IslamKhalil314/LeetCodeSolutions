public class Solution {
    public string LongestPalindrome(string s) {
     int maxLen = 0;
    string maxStr = string.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        int L = i, R = i;
        while (L >= 0 && R < s.Length && s[R] == s[L])
        {
            if (R + 1 - L > maxLen)
            {
                maxLen = R + 1 - L;
                maxStr = s[L..(R + 1)];
            }
            L--;
            R++;
        }

        L = i; R = i + 1;
        while (L >= 0 && R < s.Length && s[R] == s[L])
        {
            if (R + 1 - L > maxLen)
            {
                maxLen = R + 1 - L;
                maxStr = s[L..(R + 1)];
            }
            L--;
            R++;
        }
    }

    return maxStr;
    }
}
