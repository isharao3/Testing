import "./chunk-TTULUY32.js";

// src/app/math-ops.ts
var MathOps = class {
  divide(num1, num2) {
    if (num2 == 0) {
      throw new Error("Divide by zero error");
    }
    return num1 / num2;
  }
  cube(num2) {
    return num2 * num2 * num2;
  }
  square(num1) {
    return num1 * num1;
  }
  add(num1, num2) {
    return num1 + num2;
  }
};

// src/app/math-ops.spec.ts
describe("Sample Test Suite", () => {
  var num = 0;
  beforeEach(() => {
    num = 1;
  });
  it("Simple Test increment", () => {
    ++num;
    expect(num).toBe(2);
  });
  it("Simple Decrement", () => {
    --num;
    expect(num).toBe(0);
  });
  it("Simple String Test", () => {
    let str = "Hello Angular, we are testing ng classes using jasmine";
    expect(str).toContain("Angular");
    expect(str).toContain("jasmine");
  });
});
describe("calculator Tests", () => {
  var calculator;
  var num1 = 0;
  var num2 = 0;
  beforeAll(() => {
    calculator = new MathOps();
  });
  beforeEach(() => {
    num1 = 100;
    num2 = 200;
  });
  it("Adding two positive integers", () => {
    let result = calculator.add(num1, num2);
    expect(num1).toBeGreaterThan(0);
    expect(num2).toBeGreaterThan(0);
    expect(result).toBe(300);
  });
  it("Square of a positive integers", () => {
    let result = calculator.square(num1);
    expect(num1).toBeGreaterThan(0);
    expect(result).toBe(1e4);
  });
  it("Calculates cube of a positive integer", () => {
    let result = calculator.cube(num2);
    expect(num2).toBeGreaterThan(0);
    expect(result).toBe(8e6);
  });
  it("verify that divide by zero throws an error", () => {
    expect(() => calculator.divide(num1, 0)).toThrowError("Divide by zero error");
  });
});
//# sourceMappingURL=spec-math-ops.spec.js.map
