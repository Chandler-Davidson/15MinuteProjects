type Mutation<T> = (arr: T[]) => T[] | T;

export class List<T> {
  private constructor(
    public mutations: Mutation<T>[] = [],
  ) { }

  static get empty(): List<any> {
    return new List([]);
  }

  static fromList<T>(list: T[] | List<T>[]): List<T> {
    const el = list[0]

    if (el instanceof List) {
      const mutations = (list as List<T>[]).flatMap(l => l.mutations);
      return new List(mutations);
    }
    else
      return new List([arr => [...arr, ...(list as T[])]]);
  }

  static repeat<T>(el: T): RepeatIntermediate<T> {
    return new RepeatIntermediate(new List(), () => el);
  }

  static iterate<T>(func: (x: T) => T, el: T): IterateIntermediate<T> {
    return new IterateIntermediate(func, el);
  }

  static cycle<T>(list: List<T>): CycleIntermediate<T> {
    return new CycleIntermediate(list);
  }

  static replicate<T>(quantity: number, el: T): List<T> {
    return new List<T>([
      arr => [...arr, ...Array(quantity).fill(el)]
    ]);
  }
  
  toList(): T[] {
    let arr: T[] = [];

    for (const m of this.mutations) {
      let result = m(arr);

      if (Array.isArray(result))          
        arr = result;
      else
        arr = [result];
    }

    return arr;
  }

  head(): T | undefined {
    return this.toList()[0];
  }

  tail(): this {
    this.mutations.push(arr => arr.slice(1));
    return this;
  }

  get(index: number): any {
    return this.toList()[index];
  }

  take(quantity: number): this {
    this.mutations.push(arr => arr.slice(0, quantity));
    return this;
  }

  drop(quantity: number): this {
    this.mutations.push(arr => arr.slice(quantity, arr.length))
    return this;
  }

  length(): number {
    return this.toList().length;
  }

  nil(): any {
    return this.toList().length === 0;
  }

  cons(element: T): this {
    this.mutations.push(arr => [element, ...arr]);
    return this;
  }

  append(list: T[] | List<T>): this {
    if (Array.isArray(list))
      this.mutations.push(arr => [...arr, ...list]);
    else
      this.mutations.push(...list.mutations);
    
    return this;
  }

  slice(start?: number, end?: number): this {
    this.mutations.push(arr => arr.slice(start, end));
    return this;
  }

  map<Y>(func: (value: Y, index: number, array: Y[]) => Y): List<Y> {
    return new List<Y>([
      ...this.mutations as unknown as Mutation<Y>[],
      arr => arr.map(func)
    ]);
  }

  filter(func: (x: T) => boolean): this {
    this.mutations.push(arr => arr.filter(func));
    return this;
  }

  reverse(): this {
    this.mutations.push(arr => [...arr].reverse());
    return this;
  }

  concat(): this {
    this.mutations.push(arr => arr.flat() as T[]);
    return this;
  }

  zipWith<Y>(func: (v: T, w: T) => Y, list: List<T>): List<Y> {
    return new List<Y>([
      ...this.mutations as unknown as Mutation<Y>[],
      arr => arr.map((e, i) => func(e as unknown as T, list.get(i)))
    ])
  }

  foldr(arg0: (x: any, z: any) => any, empty: any): this {
    throw new Error("Method not implemented.");
  }

  foldl(func: (v: T, w: T) => T, initialValue: T): this {
    throw new Error("Method not implemented.");
  }

  scanr(func: (v: T, w: T) => T, initialValue: T): this {
    throw new Error("Method not implemented.");
  }

  scanl(func: (v: T, w: T) => T, initialValue: T): this {
    throw new Error("Method not implemented.");
  }

  elem(el: T): boolean {
    return this.elemIndex(el) === -1 ? false : true;
  }

  elemIndex(el: T): number {
    return this.toList().indexOf(el);
  }

  find(func: (x: T) => boolean): T | undefined {
    return this.toList().find(func);
  }

  findIndex(func: (x: T) => boolean): number {
    return this.toList().findIndex(func);
  }

  any(func: (el: T) => boolean): boolean {
    return this.toList().some(func);
  }

  all(func: (el: T) => boolean): boolean {
    return this.toList().every(func);
  }

  the(): T | undefined {
    const list = this.toList();
    const value = list[0];
    
    return (list.every(l => l === value)) ? value : undefined;
  }
}

class RepeatIntermediate<T> {
  constructor(
    private list: List<T>,
    private generateDelegate: (...args: any[]) => T
  ) { }

  take(quantity: number): List<T> {
    for (let i = 0; i < quantity; i++)
      this.list.mutations.push(arr => [...arr, this.generateDelegate()]);
    
    return this.list;
  }
}

class CycleIntermediate<T> {
  constructor(
    private list: List<T>
  ) { }

  take(quantity: number): List<T> {
    const result: T[] = [];
    const length = this.list.length();

    for (let i = 0; i < quantity; i++) {
      let position = i % length;
      result.push(this.list.get(position));
    }

    return List.fromList(result);
  }
}

class IterateIntermediate<T> {
  constructor(
    private func: (x: T) => T,
    private el: T
  ) { }

  take(quantity: number): List<T> {
    const result: T[] = [];

    for (let i = 0; i < quantity; i++) {
      result.push(this.el);
      this.el = this.func(this.el);
    }

    return List.fromList(result);
  }
}
