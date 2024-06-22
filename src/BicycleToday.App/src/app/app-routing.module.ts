import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfileComponent } from './components/profile/profile.component';
import { HomeComponent } from './components/home/home.component';
import { FailedLoginComponent } from './components/failed-login/failed-login.component';
import { MsalGuard } from '@azure/msal-angular';
import { BrowserUtils } from '@azure/msal-browser';
import { PreferencesComponent } from './components/preferences/preferences.component';

const routes: Routes = [
  {
      path: 'profile',
      component: ProfileComponent,
      canActivate: [MsalGuard]
  },
  {
    path: 'preferences',
    component: PreferencesComponent,
    canActivate: [MsalGuard]
  },
  {
      path: '',
      component: HomeComponent
  },
  {
    path: 'home',
    redirectTo: ''
},
  {
      path: 'login-failed',
      component: FailedLoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
      // Don't perform initial navigation in iframes or popups
      initialNavigation: !BrowserUtils.isInIframe() && !BrowserUtils.isInPopup() ? 'enabledNonBlocking' : 'disabled' // Set to enabledBlocking to use Angular Universal
  })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
