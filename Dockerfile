FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80 443 1433 5000 5001

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY . .

FROM build as publish
WORKDIR /src/ApiProjectX.Application
RUN dotnet publish "ApiProjectX.Application.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ApiProjectX.Application.dll"]
