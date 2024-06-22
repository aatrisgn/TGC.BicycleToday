import { Injectable } from "@angular/core";
import { BehaviorSubject, Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class LoadingService {
    private $internalLoadingState:BehaviorSubject<boolean> = new BehaviorSubject(false);
    public $loadingState:Observable<boolean> = this.$internalLoadingState.asObservable();

    constructor(){   
    }

    public StartLoading():void{
        this.$internalLoadingState.next(true);
    }

    public FinalizeLoading():void{
        this.$internalLoadingState.next(false);
    }
}