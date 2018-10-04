
class List<T> {
  private items: T[] = [];

  public add(value: T): this {
    this.items.push(value);
    return this;
  }

  public count() : number {
    return this.items.length;
  }

  public remove(value: T): this {
    let index = -1;
    while (this.items
      && this.items.length > 0
      && (index = this.items.indexOf(value)) > -1) {
      this.items.splice(index, 1);
    }
    return this;
  }

  public toString(): string {
    return this.items.toString();
  }
}

interface IDictionary<TK, TV> {
  addValue(key: TK, newItem: TV): void;
  addValues(key: TK, newItems: TV[]): void;
  removeValue(key: TK, value: TV): boolean;
}

export class MultiDictionary<K extends string, V> implements IDictionary<K, V> {

  private internalMap: Map<K, List<V>>;

  constructor() {
    this.internalMap = new Map();
  }

  private ensureKey(key: K): void {

    if (!this.internalMap.has(key)) {
      this.internalMap.set(key, new List<V>());
    }
    else {
      if (this.internalMap.get(key) == null)
        this.internalMap.set(key, new List<V>());
    }
  }

  addValue(key: K, newItem: V): void {
    this.ensureKey(key);

    var list = this.internalMap.get(key);
    list.add(newItem);

    this.internalMap.set(key, list);
  }

  addValues(key: K, newItems: V[]): void {
    this.ensureKey(key);

    var list = this.internalMap.get(key);

    for (let item of newItems) {
      list.add(item);
    }

    this.internalMap.set(key, list);
  }

  removeValue(key: K, value: V): boolean {
    if (!this.internalMap.has(key))
      return false;

    var list = this.internalMap.get(key);

    list = list.remove(value);

    if (list.count() === 0)
      this.internalMap.delete(key);

    return true;
  }
}
