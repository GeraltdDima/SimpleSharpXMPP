FROM mcr.microsoft.com/dotnet/sdk:9.0 AS sdk

WORKDIR /SimpleFishing

COPY . ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:9.0 AS runtime

WORKDIR /SimpleFishing

COPY --from=sdk /SimpleFishing/out .

WORKDIR ["dotnet", "SimpleFishing.dll" ]