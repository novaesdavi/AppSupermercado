FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/ListaSupermercado.API/ListaSupermercado.API.csproj", "src/ListaSupermercado.API/"]
COPY ["src/ListaSupermercado.Application/ListaSupermercado.Application.csproj", "src/ListaSupermercado.Application/"]
COPY ["src/ListaSupermercado.Domain/ListaSupermercado.Domain.csproj", "src/ListaSupermercado.Domain/"]
COPY ["src/Listasupermercado.InfraStructure/Listasupermercado.Infrastructure.csproj", "src/Listasupermercado.InfraStructure/"]
RUN dotnet restore "src/ListaSupermercado.API/ListaSupermercado.API.csproj"
COPY . .
WORKDIR "/src/src/ListaSupermercado.API"
RUN dotnet build "ListaSupermercado.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ListaSupermercado.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ListaSupermercado.API.dll"]