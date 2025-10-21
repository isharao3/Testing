export class MathOps {
  divide(num1: number, num2: number) {
    if (num2 == 0)
    {
      throw new Error("Divide by zero error");
    }
    return num1/num2;
  }
  cube(num2: number) {
    return num2*num2*num2;
  }
  square(num1: number) {
    return num1*num1;
  }
  add(num1: number, num2: number): number {
    return num1 + num2; 
    
  }
}
