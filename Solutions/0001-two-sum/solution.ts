function twoSum(arr: number[], target: number): number[] {
  let map = new Map<number, number>();
  for (let i = 0; i < arr.length; i++) {
    if (map.has(arr[i])) {
      return [i, map.get(arr[i])!];
    } else {
      map.set(target - arr[i], i);
    }
  }
  return [];
};
