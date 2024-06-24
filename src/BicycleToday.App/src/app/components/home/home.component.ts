import { Component, OnInit, model } from '@angular/core';
import {BreakpointObserver, BreakpointState, Breakpoints} from '@angular/cdk/layout';
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  
  public isMobile:boolean = false;
  readonly homeAddress = new FormControl('', [Validators.required]);
  readonly workAddress = new FormControl('', [Validators.required]);
  readonly storeAddressInLocalStorage = model(false);

  private storeAddressBool:boolean = false;
  
  constructor(breakpointObserver: BreakpointObserver) {
    breakpointObserver.observe([
      Breakpoints.Handset
    ]).subscribe((result:BreakpointState) => {
      this.isMobile = result.matches
    });

    this.storeAddressInLocalStorage.subscribe(value => {
      this.storeAddressBool = value.valueOf();
    })

  }

  ngOnInit(): void {

  }

  public GetWeatherRecommendation():void{
    console.log(this.homeAddress.value);
    console.log(this.workAddress.value);
    console.log(this.storeAddressBool);
  }

  public ClearFormular():void {
    this.homeAddress.reset();
    this.workAddress.reset();
    this.storeAddressInLocalStorage.set(false);
  }
}