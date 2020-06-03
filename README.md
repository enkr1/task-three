# t3

Pang Jing Hui | P1845259

## Web API Document
| No. | HTTP Method  | Route | Description |
| ------------- | ------------- | ------------- | ------------- |
| 1. | GET | api/Values | Return a string message, "Hello, {userName}." |
| 2. | GET | api/Account/UserInfo | Retrieve all the data.  |
| 3. | GET | api/v3/products  | Retrieve all the data.  |


POST api/Account/Logout	
No documentation available.

GET api/Account/ManageInfo?returnUrl={returnUrl}&generateState={generateState}	
No documentation available.

POST api/Account/ChangePassword	
No documentation available.

POST api/Account/SetPassword	
No documentation available.

POST api/Account/AddExternalLogin	
No documentation available.

POST api/Account/RemoveLogin	
No documentation available.

GET api/Account/ExternalLogin?provider={provider}&error={error}	
No documentation available.

GET api/Account/ExternalLogins?returnUrl={returnUrl}&generateState={generateState}	
No documentation available.

POST api/Account/Register	
No documentation available.

POST api/Account/RegisterExternal	
No documentation available.

## Postman testing



# Note for myself:
#### AccountController
Provides a Web API endpoint for managing user accounts. The Register action is the only one that we used in this tutorial. Other methods on the class support password reset, social logins, and other functionality.
#### ApplicationUser
Defined in /Models/IdentityModels.cs. This class is the EF model for user accounts in the membership database.
#### ApplicationUserManager
Defined in /App_Start/IdentityConfig.cs This class derives from UserManager and performs operations on user accounts, such as creating a new user, verifying passwords, and so forth, and automatically persists changes to the database.
#### ApplicationOAuthProvider
This object plugs into the OWIN middleware, and processes events raised by the middleware. It derives from OAuthAuthorizationServerProvider.
