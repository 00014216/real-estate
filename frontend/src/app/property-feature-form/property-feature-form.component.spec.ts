import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertyFeatureFormComponent } from './property-feature-form.component';

describe('PropertyFeatureFormComponent', () => {
  let component: PropertyFeatureFormComponent;
  let fixture: ComponentFixture<PropertyFeatureFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PropertyFeatureFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PropertyFeatureFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
