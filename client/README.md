
# Angular - Building a walking walking skeleton

> Goals

Complete walking skeleton and have an introductory understanding of :
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

