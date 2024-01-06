function maxArea(height: number[]): number {
  let max = 0;
    let i =0, j = height.length-1;
    while(i < j){
      let roundMax = Math.min(height[i],height[j]) * (j-i);
      max = Math.max(max,roundMax);
      if(height[i] <= height[j])
        i++;
      else 
        j--;
      
        
    }
     
    return max;
};
