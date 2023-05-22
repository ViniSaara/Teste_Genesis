import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TelaCdbComponent } from './tela-cdb.component';

describe('TelaCdbComponent', () => {
  let component: TelaCdbComponent;
  let fixture: ComponentFixture<TelaCdbComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TelaCdbComponent]
    });
    fixture = TestBed.createComponent(TelaCdbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
