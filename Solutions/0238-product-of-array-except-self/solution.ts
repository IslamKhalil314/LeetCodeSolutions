function productExceptSelf(nums: number[]): number[] {
    var valueVisted = new Map<number,number>();
    var res:number[] = [];
    for(var i = 0; i< nums.length ; i++){
        if(valueVisted.has(nums[i]))
            res.push(valueVisted.get(nums[i])!);
        else{
           var val =  nums.filter((x,j) => j != i ).reduce((prev , next) => prev * next);
            valueVisted.set(nums[i],val);
            res.push(val);
        }
    }
    return res;
};
