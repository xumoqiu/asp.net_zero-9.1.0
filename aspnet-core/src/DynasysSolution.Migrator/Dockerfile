#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/DynasysSolution.Migrator/DynasysSolution.Migrator.csproj", "src/DynasysSolution.Migrator/"]
COPY ["src/DynasysSolution.EntityFrameworkCore/DynasysSolution.EntityFrameworkCore.csproj", "src/DynasysSolution.EntityFrameworkCore/"]
COPY ["src/DynasysSolution.Core/DynasysSolution.Core.csproj", "src/DynasysSolution.Core/"]
COPY ["src/DynasysSolution.Core.Shared/DynasysSolution.Core.Shared.csproj", "src/DynasysSolution.Core.Shared/"]
RUN dotnet restore "src/DynasysSolution.Migrator/DynasysSolution.Migrator.csproj"
COPY . .
WORKDIR "/src/src/DynasysSolution.Migrator"
RUN dotnet build "DynasysSolution.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DynasysSolution.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DynasysSolution.Migrator.dll"]
