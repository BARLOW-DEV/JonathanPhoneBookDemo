#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Acme.PhoneBookDemo.Web.Public/Acme.PhoneBookDemo.Web.Public.csproj", "src/Acme.PhoneBookDemo.Web.Public/"]
COPY ["src/Acme.PhoneBookDemo.Web.Core/Acme.PhoneBookDemo.Web.Core.csproj", "src/Acme.PhoneBookDemo.Web.Core/"]
COPY ["src/Acme.PhoneBookDemo.Application/Acme.PhoneBookDemo.Application.csproj", "src/Acme.PhoneBookDemo.Application/"]
COPY ["src/Acme.PhoneBookDemo.Application.Shared/Acme.PhoneBookDemo.Application.Shared.csproj", "src/Acme.PhoneBookDemo.Application.Shared/"]
COPY ["src/Acme.PhoneBookDemo.Core.Shared/Acme.PhoneBookDemo.Core.Shared.csproj", "src/Acme.PhoneBookDemo.Core.Shared/"]
COPY ["src/Acme.PhoneBookDemo.Core/Acme.PhoneBookDemo.Core.csproj", "src/Acme.PhoneBookDemo.Core/"]
COPY ["src/Acme.PhoneBookDemo.EntityFrameworkCore/Acme.PhoneBookDemo.EntityFrameworkCore.csproj", "src/Acme.PhoneBookDemo.EntityFrameworkCore/"]
COPY ["src/Acme.PhoneBookDemo.GraphQL/Acme.PhoneBookDemo.GraphQL.csproj", "src/Acme.PhoneBookDemo.GraphQL/"]
RUN dotnet restore "src/Acme.PhoneBookDemo.Web.Public/Acme.PhoneBookDemo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/Acme.PhoneBookDemo.Web.Public"
RUN dotnet build "Acme.PhoneBookDemo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Acme.PhoneBookDemo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Acme.PhoneBookDemo.Web.Public.dll"]
