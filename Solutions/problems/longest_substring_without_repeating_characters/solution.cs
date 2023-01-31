public class Solution {
    public int LengthOfLongestSubstring(string s) {
             var last = 0;
    var counter = 0;
    var max = 0;
    var visted = new List<char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (!visted.Contains(s[i]))
        {
            counter++;
            visted.Add(s[i]);
        }
        else
        {
            if (counter > max)
            {
                max = counter;
            }
            counter = 0;
            visted = Enumerable.Empty<char>().ToList();
            i = ++last - 1;
        }
    }
    if (counter > max)
    {
        max = counter;
    }

    return max;
    }
}