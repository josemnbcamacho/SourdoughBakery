FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /src
COPY ["SourdoughBakery.Web/SourdoughBakery.Web.csproj", "SourdoughBakery.Web/"]
RUN dotnet restore "SourdoughBakery.Web/SourdoughBakery.Web.csproj"
COPY . .
WORKDIR "/src/SourdoughBakery.Web"
RUN dotnet build "SourdoughBakery.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SourdoughBakery.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SourdoughBakery.Web.dll"]