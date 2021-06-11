
# Creating a web api project using command line


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











