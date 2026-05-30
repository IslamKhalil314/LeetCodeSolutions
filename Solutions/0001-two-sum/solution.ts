function twoSum(arr: number[], target: number): number[] {
 let right = 1;
  let left = 0;
  if (arr.length === 0) {
    return [];
  }
  while (arr[right] + arr[left] !== target) {
    if (right === arr.length - 1) {
      left++;
      right = left + 1;
      continue;
    }
    if (left === arr.length - 1) {
      return [];
    }
    right++;
  }

  return [left, right];
};
