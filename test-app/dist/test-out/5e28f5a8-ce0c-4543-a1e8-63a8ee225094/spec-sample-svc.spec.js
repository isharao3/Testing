import {
  App,
  init_app
} from "./chunk-6USQC6IM.js";
import {
  Injectable,
  TestBed,
  __decorate,
  init_core,
  init_testing,
  init_tslib_es6
} from "./chunk-G3UOG67Z.js";
import "./chunk-TTULUY32.js";

// src/app/sample-svc.spec.ts
init_testing();

// src/app/sample-svc.ts
init_tslib_es6();
init_core();
var SampleSvc = class SampleSvc2 {
  add(num1, num2) {
    return num1 + num2;
  }
};
SampleSvc = __decorate([
  Injectable({
    providedIn: "root"
  })
], SampleSvc);

// src/app/sample-svc.spec.ts
init_app();
describe("SampleSvc", () => {
  let service;
  let component;
  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SampleSvc);
    component = TestBed.createComponent(App).componentInstance;
  });
  it("should be created", () => {
    expect(service).toBeTruthy();
  });
  it("should initialize app component", () => {
    expect(component).toBeTruthy();
    expect(component.title()).toBe("test-app");
  });
  it("add two numbers in the service", () => {
    expect(service.add(100, 200)).toBe(300);
  });
  it("add two numbers in the component", () => {
    expect(component.add(100, 200)).toBe(300);
  });
});
//# sourceMappingURL=spec-sample-svc.spec.js.map
