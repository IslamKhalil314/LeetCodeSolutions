class RandomizedSet {
   private _set  = new Map<number,number>();
    constructor() {
        
    }

    insert(val: number): boolean {
        if(this._set.get(val)  || this._set.get(val) == 0)
            return false;
        this._set.set(val,val) 
        return true;
    }

    remove(val: number): boolean {
        return this._set.delete(val)
    }

    getRandom(): number {
        var keys = [...this._set.keys()];
        let rand = Math.random() * keys.length;
        rand = Math.floor(rand);
        return this._set.get(keys[rand]) ?? 0;
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * var obj = new RandomizedSet()
 * var param_1 = obj.insert(val)
 * var param_2 = obj.remove(val)
 * var param_3 = obj.getRandom()
 */
