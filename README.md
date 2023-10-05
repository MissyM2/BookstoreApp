# BookstoreApp-Blazor-NET6
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

- EFCoreMocking.Api
  
  - Microsoft.AspNetCore.OpenApi
  - Swashbuckle.AspNetCore
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.Data.Sqlite.Core
  - Microsoft.EntityFrameworkCore.Sqlite.Core
  - sqlite-net-pcl
  - SQLitePCLRaw.bundle_green
  - SQLitePCLRaw.provider.dynamic_cdecl
  - Microsoft.EntityFrameworkCore
  - NLog.Extensions.Logging
  - AutoMapper.Extensions.Microsoft.DependencyInjection
 
 
- EFCoreMocking.Tests

  - Microsoft.NET.Test.Sdk
  - xunit
  - xunit.runner.visualstudio
  - coverlet.collector
  - Moq.EntityFrameworkCore
  - MockQueryable.Moq
  - Microsoft.AspNetCore.Mvc.Testing
  - FluentAssertions"
 
### Other Features
  - .Api
    - Data Transfer Objects
    - Repository Base Wrapper
  - .Tests
      - Mocks
      - Separate Controller CRUD tests
