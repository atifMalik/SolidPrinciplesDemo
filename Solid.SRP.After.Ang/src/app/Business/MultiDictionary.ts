export class MultiDictionary<K extends string, V> implements IDictionary<K, V> {

  private internalMap: Map<K, Array<V>>;

  constructor() {
    this.internalMap = new Map();
  }

  private ensureKey(key: K): void {

    if (!this.internalMap.has(key)) {
      this.internalMap.set(key, new Array<V>());
    }
    else {
      if (this.internalMap.get(key) == null)
        this.internalMap.set(key, new Array<V>());
    }
  }

  getValue(key: K): Array<V> {

    let returnArray: Array<V> = new Array<V>();

    if (this.internalMap.has(key)) {

      var list = this.internalMap.get(key);

      if (list != null)
        return list;
      else
        return returnArray;
    }
  }

  addValue(key: K, newItem: V): void {
    this.ensureKey(key);

    var list = this.internalMap.get(key);
    list.push(newItem);

    this.internalMap.set(key, list);
  }

  addValues(key: K, newItems: V[]): void {
    this.ensureKey(key);

    var list = this.internalMap.get(key);

    for (let item of newItems) {
      list.push(item);
    }

    this.internalMap.set(key, list);
  }

  removeValue(key: K, value: V): boolean {

    if (!this.internalMap.has(key))
      return false;

    var list = this.internalMap.get(key);

    const index: number = list.indexOf(value);

    if (index !== -1) {
      list.splice(index, 1);
    }

    if (list.length === 0)
      this.internalMap.delete(key);
    else
      this.internalMap.set(key, list);

    return true;
  }

  containsKey(key: K): boolean {
    return this.internalMap.has(key);
  }
}


interface IDictionary<TK, TV> {
  getValue(key: TK): Array<TV>;
  addValue(key: TK, newItem: TV): void;
  addValues(key: TK, newItems: TV[]): void;
  removeValue(key: TK, value: TV): boolean;
  containsKey(key: TK) : boolean;
}
