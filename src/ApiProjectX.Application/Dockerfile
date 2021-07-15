#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ApiProjectX.Application/ApiProjectX.Application.csproj", "ApiProjectX.Application/"]
RUN dotnet restore "ApiProjectX.Application/ApiProjectX.Application.csproj"
COPY . .
WORKDIR "/src/ApiProjectX.Application"
RUN dotnet build "ApiProjectX.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiProjectX.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiProjectX.Application.dll"]