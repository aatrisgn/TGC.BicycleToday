import { Component, OnInit } from '@angular/core';
import {BreakpointObserver, BreakpointState, Breakpoints} from '@angular/cdk/layout';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  
  public isMobile:boolean = false;
  
  constructor(breakpointObserver: BreakpointObserver) {
    breakpointObserver.observe([
      Breakpoints.Handset
    ]).subscribe((result:BreakpointState) => {
      this.isMobile = result.matches
      console.log(this.isMobile)
    });
  }

  ngOnInit(): void {

  }
}