public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    int[] el = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums.Contains(target - nums[i]))
        {

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == target - nums[i] && i != j)
                {

                    
                    el[0] = i;
                    el[1] = j;
                    break;
                }
            }

        }
    }
    return el;
    }
}