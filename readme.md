
# Angular with DotNet Core SQlite

# Authentication Basics
### Implement Basic Authentication in our app and have a basic understanding of:

1. How to store password in the Database
2. Using Inheritance in C# - DRY
3. Using C# Debugger
4. Using Data Transfer Objects (DTOs)
5. Validation
6. JSON Web Tokens (JWTs)
7. Using Service in C#
8. Middleware
9. Extension Method - DRY

**To do** : Users should able to login register view other users and privately message to other user

* add 2 additional column PasswordHash & PasswordSalt to AppUser at API project
`dotnet ef migrations add userPasswordAdded`
`dotnet ef  database update`  ctrl shift P select sqlite db file
* Create a new controller `BaseApiController`
* For debug CSP > debug> select debug & run > select .NET Core Attach beside run button
* drop db and update `dotnet ef database drop` y `dotnet ef database update `

> JWT Tokens
1. sends username + password to server
2. server validate credential and return a JWT to client
3. client send JWT with further request
4. server verifies JWT and send back response

> JWT Advantage
* No session to manage -JWTs are self contained tokens
* Portable- A single token can be used with multiple backends
* No Cookies required - mobile friendly
* Performance - Once a token is issued, there is no need to make a database to verify a users authentication

* create a ItokennService.cs under interfaces folder and another is TokenService.cs under Services folder then add scopped it to startup file , now add `System.IdentityModel.Tokens.Jwt` from nuget gallery

* add `"TokenKey":"super secret unguessable key",` TokenKey  (TokenService) to appsetting.Developement.json

* add ` [AllowAnonymous]` at `userController.cs` beside `[HttpGet]`
* add `Microsoft.AspNetCore.Authentication.JwtBearer by Microsoft` from Nuget Gallery then add service in `startup.cs`
* add Extension `IdentityServiceExtensions & ApplicationServiceExtensions`
