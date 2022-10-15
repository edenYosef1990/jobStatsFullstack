### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* npm
  ```sh
  npm install npm@latest -g
  ```
* angular 
 ```sh
 npm install -g @angular/cli
 ```
* .NET Core
* .NET Core EntityFramework CLI:
```sh
dotnet tool install --global dotnet-ef
```

### Installation
1. Clone the repo
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
2. create the database for the app with the coomand:
```sh
SqlLocalDb create "JobStatsDatabase"
```
3. create the tables (including seeding of data) for the app via the DB schema of the app, from the relative path \JobsStats.API\JobsStats.API\:
```sh
JobsStats.API>dotnet ef database update
```
4. Install NPM packages in \JobStats.WebClient\:
   ```sh
   npm install
   ```
5. in \JobStats.API\ restore packages and build ASP.NET core app:
```sh
dotnet restore && dontet build
```
6. in \JobStats.WebCLient\ build the Web app:
```sh
ng build
```

### Usage

1. in \JobStats.API\ rund ASP.NET core app:
```sh
dotnet run
```
2. in \JobStats.WebCLient\ run the Web app:
```sh
ng serve
```

### Testing
(Warning: Right now , because of an undedected bug , the test fail when run together buy succeed individually)

run in \JobStats.API\JobStats.Api.Tests\:
```sh
dotnet test
```

