function convert(s: string, numRows: number): string {
    if(numRows === 1)
      return s;
    var rows = Array.from({ length : numRows},() => '');
    var traveller = 0;
    var up = true;
    for(let c of s){
        rows[traveller] += c;

        traveller += up ? 1 : -1;

        if(traveller == rows.length - 1)
          up = false;
        else if(traveller == 0)
          up =true;
        
      
    }
    return rows.join('');
};
