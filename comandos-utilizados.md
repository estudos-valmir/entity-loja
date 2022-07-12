#Comandos utilizados dotnet

```properties

dotnet new console --framework net5.0 -n entity-loja

dotnet new sln

dotnet sln add entity-loja/entity-loja.csproj

dotnet tool update --global dotnet-ef

dotnet add entity-loja/entity-loja.csproj package Microsoft.EntityFrameworkCore.Tools --version 6.0.1

dotnet add entity-loja/entity-loja.csproj package Pomelo.EntityFrameworkCore.MySql --version 6.0.1

dotnet add entity-loja/entity-loja.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.1

dotnet-ef migrations add teste --project entity-loja/entity-loja.csproj

dotnet-ef database update --project entity-loja/entity-loja.csproj

```

#Comandos utilizados no container do SqlServer

```bash

/opt/mssql-tools/bin/sqlcmd -S localhost -U SA

```
#Comandos utilizados no container do Oracle DataBase


```bash

sqlplus system@localhost:1521/XE

alter session set "_ORACLE_SCRIPT"=true;

create user xpto identified by xptoPassword;

grant dba to xpto;


```
