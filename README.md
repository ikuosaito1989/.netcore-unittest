# Unit testing with .NET Core using dotnet test and xUnit

## set coverage threshold to 100% with dotnet test

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutput=TestResults/ /p:CoverletOutputFormat=lcov /p:Threshold=100
```

## convert to html report

```bash
./tools/reportgenerator -reports:./TestResults/coverage.info -targetdir:./TestResults/ start ./TestResults/index.htm
```

## required nuget packages


```
coverlet.collector
coverlet.msbuild
```