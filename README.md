# SnapSoftCalculatorAPI

## Working hours used:
- Aug 23, 2022: 2 hrs
- Aug 25, 2022: 1 hr
- Aug 26, 2022: 1.5 hr


Problems experienced:
- requested .NET CORE is not compatible with PostgreSQL
Error	NU1202	Package Npgsql.EntityFrameworkCore.PostgreSQL 6.0.6 is not compatible with netcoreapp3.1 (.NETCoreApp,Version=v3.1). 

I solved this by installing Microsoft.EntityFrameworkCore version 5.0.17 with Npgsql.EntityFrameworkCore.PostgreSQL version 5.0.10


