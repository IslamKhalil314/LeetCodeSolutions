public class Solution {
    public int RemoveElement(int[] nums, int val) {
       List<int> unique = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {


        if (val != nums[i])
        {
            unique.Add(nums[i]);
        }


    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (i >= unique.Count)
            nums[i] = 0;
        else nums[i] = unique[i];
    }

    return unique.Count;
    }
}
