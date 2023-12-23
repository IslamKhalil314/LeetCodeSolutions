function removeDuplicates(nums: number[]): number {
        let j = 2;
  for (let i = 2; i < nums.length; i++) {
    console.log(i,j)
    if (nums[i] !== nums[j - 2]) {
      nums[j++] = nums[i];
    }
    console.log(nums);
  }
  
  return j;
};
