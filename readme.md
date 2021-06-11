
# Creating an Web Api Project using Command Line

> Learning Goals

1. Using the .Net CLI
2. API Controller and endpoints
3. Entity Framework
4. The API Project structure
5. Configuring and Environment variables
6. Source Control

> Let's Start
* Show all commands `dotnet -h `   list of template `dotnet new -h`
* Create a solution file `dotnet new sln` Create a folder `dotnet new webapi -o API`
* Add the API project to solution file `dotnet sln add API`
* Open project to vscode `code .`

> Extensions
* Install C# * Extension By Microsoft
* Install C# * Extension By JosKreativ
* Enable Auto Save from Edit menu
* File > Preference > Settings ctrl+, change font size or other thing .......
* Ctrl +, type exclude then type **/bin *Add Patern* it will Exclude bin folder from project

* Cd API then run `dotnet dev-certs https --trust` to trust https

* Add Extension **NuGet Gallery**  pcislo,   `ctrl Shift P` search nuget gallery

* Instal MicroSoftEntityFrameworkCore.SQlite

> DbContext

* create another new folder Data to add DbContext  create a options constructor ,add services.AddDbContext() at startup.cs
* try to instal dotnet-ef from nuget.org ` dotnet tool install --global dotnet-ef --version 6.0.0-preview.4.21253.1`
* try `dotnet ef migrations add initialCreate -o Data/Migrations` it will show an error ! so copy `Microsoft.EntityFrameworkCore.Design`
  then ctrl shift p > go to Nuget Gallery ... paste last command then install from here . again run first command ef then it should be success then `dotnet ef database update`

> SQLite
* install Sqlite alexcvzz , ctrl shift p > type sqlite > chose a database > select database > then it will apper in app folder and inside sqlite explorer it will show database

> Controller
* add controller UserController and must add `[ApiController]` and `[Route("api/[controller]")]`

> Git
* Open another powershell inside solution check ` git status ` if not found any git initialized `git init`

```ps
git remote add origin [url]
git add (all other files)
git commit -m 'reinitialized files'
git push origin master --force
```



# Staring  Angular

> Goals

Complete walking skeleton and have an introductory understandingof :
1. Using Angular CLI
2. How to create a new angular app
3. The Angular Project file
4. Angular bootstrap process
5. Using the Angular HTTP Client Service
6. Running An Angular app over HTTPS
7. How to add packages using NPM
8. add ssl certificate

```ps

node --version in DatingApp
npm --version
npm install -g @angular/cli
ng new client  rm -rf node_modules && npm install *creating angular app named client* select y and then css
--if missing node_modules npm install typescript --save-dev
cd client
ng serve
```
> Extensions
* Angular Language Service By Angular
* Angular Snippets By Jhon Papa
* Bracket Pair Colorizer 2 Coenradds
*

> Shift Alt F to format .ts file in vscode

>  Allow COR's Policy
```cs
  services.AddCors();
  app.UseCors(policy=>policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200/")); *[before authorization]
```
now see the the result in Network tab

> Bootstrap (ng)
Run it to client `ng add ngx-bootstrap`
add style in  angular.json `"node_modules/ngx-bootstrap/datepicker/bs-datepicker.css",`

* Font AweSome : `npm install font-awesome`
* add ssl cert with key





