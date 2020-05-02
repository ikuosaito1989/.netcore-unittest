# Unit testing with .NET Core using dotnet test and xUnit

![Alt Text](/assets/images/coverage.png)

## set coverage threshold to 100% with dotnet test

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutput=TestResults/ /p:CoverletOutputFormat=lcov /p:Threshold=100
```

## convert to html report

### How to install reportgenerator using .NET Global Tools

```bash
dotnet tool install -g dotnet-reportgenerator-globaltool
```

### convert
```bash
reportgenerator -reports:./TestResults/coverage.info -targetdir:./TestResults/ start ./TestResults/index.htm
```

## required nuget packages


```
coverlet.collector
coverlet.msbuild
```