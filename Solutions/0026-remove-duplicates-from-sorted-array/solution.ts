function removeDuplicates(nums: number[]): number {
 var _set =  new Set(nums);
 var arr = [..._set];
 arr.forEach((x,i) => nums[i]= x);
 return _set.size;
};
