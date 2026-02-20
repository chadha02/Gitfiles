# GitfilesApp

A minimal .NET console app scaffolded from your `HostApplicationBuilder` + memory cache starting point.

## Requirements

- .NET SDK 8.0+

## Run

```bash
dotnet restore
dotnet run
```

## Where to start coding

- Edit `Program.cs` and add your services and app logic.
- You can register dependencies using `builder.Services` before `builder.Build()`.
- Resolve dependencies from `host.Services` after build.
