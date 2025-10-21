export class Todo {
    nums: number[] = [1,2,3,4]

    add(n1:number){
        this.nums.push(n1);

    }
    get()
    {
        return this.nums;
    }
}
