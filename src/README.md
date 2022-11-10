to revert the first migration if it's already applied:

```
cd .\TomShirley.EFCore.Sample.Endpoint
dotnet ef database update 0 --project ..\TomShirley.EFCore.Sample.Database\
```

then remove the migration so you can redo it:

```
cd .\TomShirley.EFCore.Sample.Endpoint
dotnet ef migrations remove  --project ..\TomShirley.EFCore.Sample.Database\
```

create a migration:

```
cd .\TomShirley.EFCore.Sample.Endpoint
dotnet ef migrations add InitialCreate --project ..\TomShirley.EFCore.Sample.Database\
```

to update the database:

```
dotnet ef database update --project ..\TomShirley.EFCore.Sample.Endpoint\
```


to create migration from existing db:

```
cd .\TomShirley.EFCore.Sample.Endpoint
dotnet ef dbcontext scaffold Name=ConnectionStrings:BlogsDatabase Microsoft.EntityFrameworkCore.SqlServer `
    --project ..\TomShirley.EFCore.Sample.Database\ `
    --no-onconfiguring
dotnet ef migrations add InitialCreate  --project ..\TomShirley.EFCore.Sample.Database\
```

then, remove code in up/down funcs and apply:

```
dotnet ef database update --project ..\TomShirley.EFCore.Sample.Endpoint\
```

to do a vuln scan:

```
cd src
dotnet list package --vulnerable 
```

## TODO

* Controller/Model versioning to support multiple blogs api specs
 