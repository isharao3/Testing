import "./chunk-TTULUY32.js";

// src/app/todo.ts
var Todo = class {
  nums = [1, 2, 3, 4];
  add(n1) {
    this.nums.push(n1);
  }
  get() {
    return this.nums;
  }
};

// src/app/todo.spec.ts
describe("Todo", () => {
  it("should create an instance", () => {
    expect(new Todo()).toBeTruthy();
  });
  describe("Lab", () => {
    var td;
    beforeAll(() => {
      td = new Todo();
    });
    it("Get", () => {
      let result = td.get();
      expect(result).toBeTruthy();
    });
    it("add", () => {
      let result = td.add(5);
      var lastitem = td.nums[td.nums.length - 1];
      expect(lastitem).toBe(5);
      expect(td.nums.length).toBeGreaterThan(1);
    });
  });
});
//# sourceMappingURL=spec-todo.spec.js.map
