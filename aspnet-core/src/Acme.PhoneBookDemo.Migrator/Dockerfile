#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Acme.PhoneBookDemo.Migrator/Acme.PhoneBookDemo.Migrator.csproj", "src/Acme.PhoneBookDemo.Migrator/"]
COPY ["src/Acme.PhoneBookDemo.EntityFrameworkCore/Acme.PhoneBookDemo.EntityFrameworkCore.csproj", "src/Acme.PhoneBookDemo.EntityFrameworkCore/"]
COPY ["src/Acme.PhoneBookDemo.Core/Acme.PhoneBookDemo.Core.csproj", "src/Acme.PhoneBookDemo.Core/"]
COPY ["src/Acme.PhoneBookDemo.Core.Shared/Acme.PhoneBookDemo.Core.Shared.csproj", "src/Acme.PhoneBookDemo.Core.Shared/"]
RUN dotnet restore "src/Acme.PhoneBookDemo.Migrator/Acme.PhoneBookDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Acme.PhoneBookDemo.Migrator"
RUN dotnet build "Acme.PhoneBookDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.PhoneBookDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.PhoneBookDemo.Migrator.dll", "-s"]
