function majorityElement(nums: number[]): number {
  var occ = new Map<number , number>();
  for (var num of nums){
    var freq = (occ.get(num) ?? 0) + 1
    occ.set(num,freq);
    if(freq > nums.length / 2)
      return num;
  }
  return 0;
};
