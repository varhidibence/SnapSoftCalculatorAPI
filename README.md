# SnapSoftCalculatorAPI

## Working hours used:
- Aug 23, 2022: 2 hrs
- Aug 25, 2022: 1 hr
- Aug 26, 2022: 1.5 hr
- Aug 27, 2022: 2.5 hr
- Aug 28, 2022: 1 hr

## Concepts
### Relational database
EF originally could not store type of List<int>, so my design was to store calculations and the numbers of each calculation in many-to-many relationship.
  That means each calculation has one list of integers of the input, and one list of integers of the calculated numbers. This concept does not break 1NF.

### Problems experienced:
- requested .NET CORE is not compatible with PostgreSQL
Error	NU1202	Package Npgsql.EntityFrameworkCore.PostgreSQL 6.0.6 is not compatible with netcoreapp3.1 (.NETCoreApp,Version=v3.1). 

I solved this by installing Microsoft.EntityFrameworkCore version 5.0.17 with Npgsql.EntityFrameworkCore.PostgreSQL version 5.0.10
  
## Conclusion
  - I enjoyed creating and implementing this web APi.
  - I've implemented only 2 version of algorithm (a and b) cause lack of time.
  - I could not finish integraiton data storing with PostgreSQL, models of data storing can be reviewed in source code.
  - I could not set port 3000 in the release API, I've tested during coding with SwaggerUI, and it worked for me correctly.
  - Release app listen on port 5000.


