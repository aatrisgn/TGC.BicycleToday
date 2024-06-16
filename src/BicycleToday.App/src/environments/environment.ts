// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
export const environment = {
  production: false,
  msalConfig: {
      auth: {
          clientId: "b2fa0df6-b866-4169-b1d7-a593de16af9a",
      }
  },
  apiConfig: {
      scopes: ["https://TGCIdentityService.onmicrosoft.com/bicycletoday/basic.read"],
      uri: "/api/"
  },
  b2cPolicies: {
      names: {
          signUpSignIn: "B2C_1_signinsignup1",
          resetPassword: "B2C_1_password_reset",
          editProfile: "B2C_1_edit_profile"
      },
      authorities: {
          signUpSignIn: {
              authority: "https://TGCIdentityService.b2clogin.com/TGCIdentityService.onmicrosoft.com/B2C_1_signinsignup1"
          },
          resetPassword: {
              authority: "https://TGCIdentityService.b2clogin.com/TGCIdentityService.onmicrosoft.com/B2C_1_password_reset"
          },
          editProfile: {
              authority: "https://TGCIdentityService.b2clogin.com/TGCIdentityService.onmicrosoft.com/B2C_1_edit_profile"
          }
      },
      authorityDomain: "TGCIdentityService.b2clogin.com"
  }
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.
