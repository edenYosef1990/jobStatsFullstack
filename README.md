
<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

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
1. create the database for the app with the coomand:
```sh
SqlLocalDb create "JobStatsDatabase"
```
2. create the tables (including seeding of data) for the app via the DB schema of the app, from the relative path \JobsStats.API\JobsStats.API:
```sh
JobsStats.API>dotnet ef database update
```
1. Get a free API Key at [https://example.com](https://example.com)
2. Clone the repo
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. Enter your API in `config.js`
   ```js
   const API_KEY = 'ENTER YOUR API';
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.

_For more examples, please refer to the [Documentation](https://example.com)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>
