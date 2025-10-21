import { TestBed } from '@angular/core/testing';

import { SampleSvc } from './sample-svc';
import { App } from './app';

describe('SampleSvc', () => {
  let service: SampleSvc;
  let component: App;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SampleSvc);
    component=TestBed.createComponent(App).componentInstance;
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
    
  });
  it('should initialize app component',()=>{
    expect(component).toBeTruthy();
    expect(component.title()).toBe('test-app');
  })
  it('add two numbers in the service',()=>{
    expect(service.add(100,200)).toBe(300);
  })

  it('add two numbers in the component',()=>{
    expect(component.add(100,200)).toBe(300);
  })
});
