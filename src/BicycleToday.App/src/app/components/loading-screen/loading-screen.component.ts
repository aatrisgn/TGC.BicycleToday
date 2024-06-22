import { Component } from '@angular/core';
import { LoadingService } from 'src/app/services/loading.service';

@Component({
  selector: 'app-loading-screen',
  templateUrl: './loading-screen.component.html',
  styleUrl: './loading-screen.component.sass'
})
export class LoadingScreenComponent {
  public isLoading:boolean = false;

  constructor(private readonly loadingService:LoadingService) {
    loadingService.$loadingState.subscribe((isLoading:boolean) => {
      this.isLoading = isLoading;
    })  
  }
}
