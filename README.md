# 3SDevTest

First solution is a Razor Pages Web Application

# Environment

- Visual Studio 2022
- .Net 7
- [SQL Server Management Studio (SSMS) 19.1](https://aka.ms/ssmsfullsetup)
- SQL Server 2022 - [SQL2022-SSEI-Dev.exe](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) 

**Note that**

- The database on `Server=.;Database=ASPRazor3SDevTest`

my appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=ASPRazor3SDevTest;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

# Instruction

1. Clone the solution in Visual Studio
2.  Alt + T - to open `Tools` tap
3.  open `NuGet Package Manager` > `Package Manager Console`
4.  in the opened console type `add-migration SeedAllTables`
5.  type `update-database`
6.  F10 - run the application 
