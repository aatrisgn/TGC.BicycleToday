import { Component } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';
import { UserInfoServic } from 'src/app/services/user-info.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.sass'
})
export class NavbarComponent {

  public loginDisplay:boolean = false;
  public userName:string = '';

  constructor(private readonly authService:AuthService, private readonly userInfoService:UserInfoServic) {
    this.loginDisplay = authService.loginDisplay;
  }

  public getUserName():string{
    return this.userInfoService.GetUserName()
  }

  public editProfile():void {
    this.authService.editProfile();
  }

  public logout():void {
    this.authService.logout();
  }

  public login():void {
    this.authService.login();
  }
}
