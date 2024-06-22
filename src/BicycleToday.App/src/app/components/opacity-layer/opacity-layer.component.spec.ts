import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OpacityLayerComponent } from './opacity-layer.component';

describe('OpacityLayerComponent', () => {
  let component: OpacityLayerComponent;
  let fixture: ComponentFixture<OpacityLayerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [OpacityLayerComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OpacityLayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
