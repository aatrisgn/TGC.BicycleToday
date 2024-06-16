export const environment = {
  production: true,
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
      authorityDomain: "TGCIdentityService.onmicrosoft.com"
  }
};