public class Solution {
    public int Tribonacci(int n) {
             int[] seq = new int[38];
    seq[0] = 0;
    seq[1] = 1;
    seq[2] = 1;
    for (int i = 3; i < seq.Length; i++)
    {
        seq[i] = seq[i - 1] + seq[i - 2] + seq[i - 3];
    }

    return seq[n];
    }
}