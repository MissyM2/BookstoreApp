# BookstoreApp
ASP.NET, Blazor (Server/WebAssembly), API, EF Core, SqlServer, JWT, Auth

### Overview

This app is an .net Web API, version 7.0, a Blazor Server and Blazor WebAssembly front ends.   using EF Core with a SqliteDB.  The subject is an employee db and includes mocking of repository and controller tests.

### Structure
Solution Name: BookStoreApp

Projects:
- BookStoreApp.Api
  - /Configurations
  - /Contracts
  - /Controllers
  - /Data
  - /logs
  - /Migrations
  - /Models
  - /Repositories
  - /Static
  - /wwwroot

- BookStoreApp.Blazor.Server.UI
   - /Configurations
      - MapperConfig.cs
   - /Data
   - /Models
   - /Pages
   - /Providers
      -  ApiAuthenticationStateProvider.cs
   -  /Services
   -  /Shared
   -  /Static
   -  /www.root 

 - BookStoreApp.Blazor.WebAssembly.UI
   - /Configurations
   - /Models
   - /Pages
   - /Providers
      - ApiAuthenticationStateProvider.cs  
   - /Services
   - /Shared
   - /Static
   - /wwwroot
  
- EFCoreMocking.Tests
    -  TestDataHelper.cs
    - /Mocks
         - FakeEmployeeDb.cs
         - MockIEmployeeRepository.cs
         - MockIRepositoryWrapper.cs
   -  /Tests
         - EmployeeControllerCreateTests.cs
         - EmployeeControllerDeleteTests.cs
         - EmployeeControllerReadTests.cs
         - EmployeeControllerUpdateTests.cs
         - EmployeesControllerTestWithMockQueryable
         - EmployeesControllerTestWithMoq_EntityFrameworkCore.cs
         - ModelValidationTests.cs

### Libraries

- BookstoreApp.API
  - AutoMapper.Extensions.Microsoft.DependencyInjection
  - Microsoft.AspNetCore.Authentication.JwtBearer
  - Microsoft.AspNetCore.Identity.EntityFrameworkCore
  - Microsoft.AspNetCore.Mvc.NewtonsoftJson
  - Microsoft.EntityFrameworkCore.Design
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.VisualStudio.Web.CodeGeneration.Design
  - Serilog.AspNetCore
  - Serilog.Expressions
  - Serilog.Sinks.Seq
  - Swashbuckle.AspNetCore
 
- BookstoreApp.Blazor.Server.UI
  - AutoMapper.Extensions.Microsoft.DependencyInjection
  - Blazored.LocalStorage
  - Newtonsoft.Json
  - System.IdentityModel.Tokens.Jwt
 
- BookstoreApp.Blazor.WebAssembly.UI
  - AutoMapper.Extensions.Microsoft.DependencyInjection
	- Blazored.LocalStorage
	- Microsoft.AspNetCore.Authorization
	- Microsoft.AspNetCore.Components.Authorization
	- Microsoft.AspNetCore.Components.WebAssembly
	- Microsoft.AspNetCore.Components.WebAssembly.DevServer
	- Newtonsoft.Json
	- System.IdentityModel.Tokens.Jwt
 
### Other Features
  - Automapper for conversion between Data Transfer Objects and models
  - AspNetCore Identity and IdentityDbContext
  - EF Core
  - Serilog
  - Virtualization
   
