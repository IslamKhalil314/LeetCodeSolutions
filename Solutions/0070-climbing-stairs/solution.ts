function climbStairs(n: number): number {
 if(n <= 2){
        return n;
    }
    let x = 1,y =2 , res= 0;
for(let i = 3 ; i <= n; i++){
        res = x + y;
        x = y;
        y = res;
}
   return res;
};
