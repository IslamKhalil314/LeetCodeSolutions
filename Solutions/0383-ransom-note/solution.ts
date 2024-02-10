function canConstruct(ransomNote: string, magazine: string): boolean {
     let map = new Map<string,number>();
    [...magazine].forEach(c => {
        map.set(c , (map.get(c) ?? 0) + 1)
    });

    
        for(let c of ransomNote){
            let occurenc = map.get(c) ?? 0;
             if(!map.has(c) || occurenc <= 0 )
                return false;

            map.set(c ,occurenc - 1)
        }

       
    
    return true;
};
