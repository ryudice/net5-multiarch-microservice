
FROM mcr.microsoft.com/dotnet/sdk:5.0.100-buster-slim as build

WORKDIR /build

COPY . /build

RUN dotnet build -c Release -o output

FROM mcr.microsoft.com/dotnet/aspnet:5.0.0-alpine3.12

WORKDIR /app

COPY --from=build /build/output/ .

ENTRYPOINT ["dotnet", "MinimalMicroservice.dll"]