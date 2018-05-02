# One-Vote
Project for CSCI 455 — Principles of Computing Security, Spring 2018.

Gregory Goh [@ShinyTeeth](https://github.com/ShinyTeeth)

William Frey [@Will-Frey](https://github.com/Will-Frey)

Tommy Bohde [@InsanesTheName](https://github.com/InsanesTheName)

## Abstract:
Secure voting system implemented in C#. 

## Technicals

#### Downloads
To download code: `$ git clone https://github.com/ShinyTeeth/One-Vote.git`

#### Structure
The following is a summary of which source directories and files are vital
to the project.

- `Migrations` contains a record of database migrations based on 
.NET Entity Framework Core and a Code First approach.
- `Models` contains the models used for structuring data. Important
to note is that `OnevoteContext.cs` is what establishes an
Object-Relational Mapping (ORM) interface between the database
and this webapp.
- `Pages` contains the front-end logic and design for the pages of this webapp.
- `Repositories` is NOT used in the webapp; it exists for testing purposes
only, if a database instance is not obtainable.
- `Program.cs` and `Startup.cs` define the services and middleware used for
the webapp, as well as the parameters for running the webapp.


#### Requirements
[.NET Core](https://www.microsoft.com/net/learn/get-started/) >= 2.1.4

#### Instructions
To run the code, ensure that the .NET CLI is installed as linked above.
A pre-compiled build of this project has been included in 
[release/](https://github.com/ShinyTeeth/One-Vote/tree/master/release).
Open a shell at the root of this directory, and type the following:

```
cd release
dotnet onevote.dll
```

Navigate to https://localhost

If your browser shows "not trusted" or "not secure", this is because the SSL certificate
is self-signed. Add the certificate to your operating system's trusted root certificate
authority and restart your browser to remove this error. Note that this is not necessary 
for SSL to function - the data is still encrypted, the error simply means that the browser 
does not have the server (localhost) in its list of trusted CAs. 

#### License
MIT licensed. See the bundled [LICENSE](/LICENSE) file for more details.
