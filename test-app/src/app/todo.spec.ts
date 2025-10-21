import { Todo } from './todo';

describe('Todo', () => {
  it('should create an instance', () => {
    expect(new Todo()).toBeTruthy();
  });

  describe('Lab', () =>{
    var td: Todo;
    beforeAll(()=>{
         td=new Todo();
      });

    it('Get',()=>{
      let result= td.get();
      expect(result).toBeTruthy();
    })
    it('add', ()=>{
      let result=td.add(5);
      var lastitem=td.nums[td.nums.length-1]
      expect(lastitem).toBe(5);
      expect(td.nums.length).toBeGreaterThan(1);
    })
  })
});
