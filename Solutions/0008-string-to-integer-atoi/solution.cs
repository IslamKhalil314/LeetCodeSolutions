public class Solution {
     List<char> digits = new List<char>() { '0','1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public int MyAtoi(string s) {
       
    var trimed = s.Trim();;
    int res = 0;
    bool isNeg = false;
     if (string.IsNullOrEmpty(trimed)) return res;
    if (trimed[0] == '+')
    {
        isNeg = false;
        trimed = trimed.Substring(1);
    }
    else if (trimed[0] == '-')
    {
        isNeg = true;
        trimed = trimed.Substring(1);
    }

    foreach (var item in trimed)
    {
        if (!digits.Contains(item))
            break;
        if (!int.TryParse(res.ToString() + item, out int y))
        {
            return isNeg ? int.MinValue : int.MaxValue;
        }
        res = y;



    }

    return isNeg ? -res : res;
    }
}
