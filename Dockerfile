# Etapa 1: Construção
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY AppMinhaPagina.Web/AppMinhaPagina.Web.csproj ./AppMinhaPagina.Web/
COPY AppMinhaPagina.Shared/AppMinhaPagina.Shared.csproj ./AppMinhaPagina.Shared/
RUN dotnet restore "AppMinhaPagina.Web/AppMinhaPagina.Web.csproj"
COPY . .
RUN dotnet build "AppMinhaPagina.Web/AppMinhaPagina.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppMinhaPagina.Web/AppMinhaPagina.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppMinhaPagina.Web.dll"]