public class Solution {
    public string LongestCommonPrefix(string[] strs) {
       int shortslen = strs.Min(x => x.Length);
    var shortest = strs.FirstOrDefault(x => x.Length == shortslen);
    for (int i = 0; i < shortslen; i++)
    {
        if (strs.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];

    }
    return shortest;
    }
}
