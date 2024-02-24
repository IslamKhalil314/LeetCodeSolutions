function intToRoman(num: number): string {
        let romanMap  = new Map<number,string>( 
        [  
            [ 1         ,      "I"  ] ,
            [ 4         ,      "IV" ] ,
            [ 5         ,      "V"  ] ,
            [ 9         ,      "IX" ] ,
            [ 10        ,      "X"  ] ,
            [ 40        ,      "XL" ] ,
            [ 50        ,      "L"  ] ,
            [ 90        ,      "XC" ] ,
            [ 100       ,      "C"  ] ,
            [ 400       ,      "CD" ] ,
            [ 500       ,      "D"  ] ,
            [ 900       ,      "CM" ] ,
            [ 1000      ,      "M"  ] ,
        ] )

    if(romanMap.has(num))
        return romanMap.get(num) ?? "";

    let romanString = "";
    while (num != 0){
        let biggestNumber = [...romanMap.keys()].filter(x => x <= num).pop();
        romanString += romanMap.get(biggestNumber ?? 0) ?? ""
        num -= biggestNumber ?? 0;

    }
    return romanString;
};
