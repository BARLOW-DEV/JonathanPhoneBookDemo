#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/LibraryDemo.Migrator/LibraryDemo.Migrator.csproj", "src/LibraryDemo.Migrator/"]
COPY ["src/LibraryDemo.EntityFrameworkCore/LibraryDemo.EntityFrameworkCore.csproj", "src/LibraryDemo.EntityFrameworkCore/"]
COPY ["src/LibraryDemo.Core/LibraryDemo.Core.csproj", "src/LibraryDemo.Core/"]
COPY ["src/LibraryDemo.Core.Shared/LibraryDemo.Core.Shared.csproj", "src/LibraryDemo.Core.Shared/"]
RUN dotnet restore "src/LibraryDemo.Migrator/LibraryDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/LibraryDemo.Migrator"
RUN dotnet build "LibraryDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LibraryDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LibraryDemo.Migrator.dll", "-s"]
