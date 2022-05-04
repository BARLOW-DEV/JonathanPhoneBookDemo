#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/LibraryDemo.Web.Public/LibraryDemo.Web.Public.csproj", "src/LibraryDemo.Web.Public/"]
COPY ["src/LibraryDemo.Web.Core/LibraryDemo.Web.Core.csproj", "src/LibraryDemo.Web.Core/"]
COPY ["src/LibraryDemo.Application/LibraryDemo.Application.csproj", "src/LibraryDemo.Application/"]
COPY ["src/LibraryDemo.Application.Shared/LibraryDemo.Application.Shared.csproj", "src/LibraryDemo.Application.Shared/"]
COPY ["src/LibraryDemo.Core.Shared/LibraryDemo.Core.Shared.csproj", "src/LibraryDemo.Core.Shared/"]
COPY ["src/LibraryDemo.Core/LibraryDemo.Core.csproj", "src/LibraryDemo.Core/"]
COPY ["src/LibraryDemo.EntityFrameworkCore/LibraryDemo.EntityFrameworkCore.csproj", "src/LibraryDemo.EntityFrameworkCore/"]
COPY ["src/LibraryDemo.GraphQL/LibraryDemo.GraphQL.csproj", "src/LibraryDemo.GraphQL/"]
RUN dotnet restore "src/LibraryDemo.Web.Public/LibraryDemo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/LibraryDemo.Web.Public"
RUN dotnet build "LibraryDemo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LibraryDemo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LibraryDemo.Web.Public.dll"]
