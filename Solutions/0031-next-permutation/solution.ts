/**
 Do not return anything, modify nums in-place instead.
 */
function nextPermutation(arr: number[]): void {
  let pivot = arr.length - 2;
  while (pivot >= 0 && arr[pivot] >= arr[pivot + 1]) {
    pivot--;
  }
  if (pivot === -1) {
    reverse(pivot + 1, arr.length - 1, arr);
    return;
  }
  let rightMost = arr.length - 1;

  while (arr[pivot] >= arr[rightMost]) {
    rightMost--;
  }

  [arr[pivot], arr[rightMost]] = [arr[rightMost], arr[pivot]];

  reverse(pivot + 1, arr.length - 1, arr);
};

function reverse(start: number, end: number, arr: number[]) {
  while (start < end) {
    [arr[start], arr[end]] = [arr[end], arr[start]];
    start++;
    end--;
  }
}
