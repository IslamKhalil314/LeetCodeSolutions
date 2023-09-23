public class Solution {
     Dictionary<char, char> dict = new Dictionary<char, char>() {
        { '}','{' },
        { ']','[' },
        { ')','(' },
    };
    Stack<char> openingStack = new Stack<char>();
    public bool IsValid(string s) {
       for (int i = 0; i < s.Length; i++)
    {

        if (!dict.Keys.Contains(s[i]))
        {
            if (i == s.Length - 1)
                return false;
            else
                openingStack.Push(s[i]);
        }
        else
        {
            if (openingStack.Count == 0)
                return false;
            if (dict[s[i]] != openingStack.Pop())
                return false;
        }
    }
    return openingStack.Count == 0;
    }
}
