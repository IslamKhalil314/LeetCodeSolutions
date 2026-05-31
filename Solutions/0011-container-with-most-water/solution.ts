function maxArea(arr: number[]): number {
   let maxWater = 0,
    left = 0,
    right = arr.length - 1;

  while (left < right) {
    maxWater = Math.max(
      maxWater,
      Math.min(arr[left], arr[right]) * (right - left)
    );
    if (arr[left] > arr[right]) {
      right--;
    } else if (arr[right] > arr[left]) {
      left++;
    } else {
      right--;
      left++;
    }
  }
  return maxWater;
};
