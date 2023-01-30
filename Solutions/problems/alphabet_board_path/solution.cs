public class Solution {
    public string AlphabetBoardPath(string target) {
        var board = new List<string>() { "abcde", "fghij", "klmno", "pqrst", "uvwxy", "z" };
        string path = string.Empty;
        char current = 'a';
        foreach (var item in target)
        {
            if (item == current)
            {
                path += "!";
                continue;
            }
            var currentRow = board.FirstOrDefault(x => x.Contains(current));
            var itemRow = board.FirstOrDefault(x => x.Contains(item));

            var currentIndex = board.IndexOf(currentRow);
            var itemIndex = board.IndexOf(itemRow);
            var steps = currentIndex - itemIndex;

            var currentCharIndex = currentRow.IndexOf(current);
            var nextCharIndex = itemRow.IndexOf(item);
            var Hsteps = currentCharIndex - nextCharIndex;



            if (steps < 0)
            {
                if (item == 'z' && Hsteps != 0)
                    path += string.Concat(System.Linq.Enumerable.Repeat("D", Math.Abs(steps) - 1));
                else
                    path += string.Concat(System.Linq.Enumerable.Repeat("D", Math.Abs(steps)));
            }
            else if (steps > 0)
            {
                path += string.Concat(System.Linq.Enumerable.Repeat("U", Math.Abs(steps)));
            }

            if (Hsteps > 0)
            {
                if (item == 'z' && Hsteps != 0)
                    path += string.Concat(System.Linq.Enumerable.Repeat("L", Math.Abs(Hsteps))) + "D";
                else
                    path += string.Concat(System.Linq.Enumerable.Repeat("L", Math.Abs(Hsteps)));


            }
            else if (Hsteps < 0)
            {
                path += string.Concat(System.Linq.Enumerable.Repeat("R", Math.Abs(Hsteps)));
            }

            path += "!";
            current = item;
        }

        return path;
    }
}