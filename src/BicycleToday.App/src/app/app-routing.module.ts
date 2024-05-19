import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfileComponent } from './components/profile/profile.component';
import { HomeComponent } from './components/home/home.component';
import { FailedLoginComponent } from './components/failed-login/failed-login.component';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

const routes: Routes = [
  {
      path: 'profile',
      component: ProfileComponent,
      canActivate: [MsalGuard]
  },
  {
      path: '',
      component: HomeComponent
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
