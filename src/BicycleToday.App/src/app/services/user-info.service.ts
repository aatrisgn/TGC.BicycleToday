import { Injectable } from "@angular/core";
import { AuthService } from "./auth.service";

@Injectable({
    providedIn: 'root'
})
export class UserInfoServic {

    constructor(private readonly authService:AuthService) {

    }

    public isUserLoggedIn():boolean{
        return this.authService.loginDisplay
    }

    public GetUserName():string {
        const account = this.authService.getAccount();

        console.log()
        console.log(account);

        if(this.isUserLoggedIn()){
            return account.username;
        } else {
            return ''
        }
    }
}