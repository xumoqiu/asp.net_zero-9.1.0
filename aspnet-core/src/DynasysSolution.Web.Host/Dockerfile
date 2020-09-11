#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/DynasysSolution.Web.Host/DynasysSolution.Web.Host.csproj", "src/DynasysSolution.Web.Host/"]
COPY ["src/DynasysSolution.Web.Core/DynasysSolution.Web.Core.csproj", "src/DynasysSolution.Web.Core/"]
COPY ["src/DynasysSolution.Application/DynasysSolution.Application.csproj", "src/DynasysSolution.Application/"]
COPY ["src/DynasysSolution.Application.Shared/DynasysSolution.Application.Shared.csproj", "src/DynasysSolution.Application.Shared/"]
COPY ["src/DynasysSolution.Core.Shared/DynasysSolution.Core.Shared.csproj", "src/DynasysSolution.Core.Shared/"]
COPY ["src/DynasysSolution.Core/DynasysSolution.Core.csproj", "src/DynasysSolution.Core/"]
COPY ["src/DynasysSolution.EntityFrameworkCore/DynasysSolution.EntityFrameworkCore.csproj", "src/DynasysSolution.EntityFrameworkCore/"]
COPY ["src/DynasysSolution.GraphQL/DynasysSolution.GraphQL.csproj", "src/DynasysSolution.GraphQL/"]
RUN dotnet restore "src/DynasysSolution.Web.Host/DynasysSolution.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/DynasysSolution.Web.Host"
RUN dotnet build "DynasysSolution.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DynasysSolution.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DynasysSolution.Web.Host.dll"]
