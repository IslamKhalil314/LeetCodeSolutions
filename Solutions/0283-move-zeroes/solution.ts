/**
 Do not return anything, modify nums in-place instead.
 */
function moveZeroes(arr: number[]): void {
     let left = 0;
  for (let right = 0; right < arr.length; right++) {
    if (arr[right] !== 0) {
      if (left !== right) {
        [arr[right], arr[left]] = [arr[left], arr[right]];
      }
      left++;
    }
  }
};
