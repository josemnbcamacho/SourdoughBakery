FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["SourdoughBakery.WebApi/SourdoughBakery.WebApi.csproj", "SourdoughBakery.WebApi/"]
COPY ["SourdoughBakery.Business/SourdoughBakery.Business.csproj", "SourdoughBakery.Business/"]
COPY ["SourdoughBakery.Core/SourdoughBakery.Core.csproj", "SourdoughBakery.Core/"]
RUN dotnet restore "SourdoughBakery.WebApi/SourdoughBakery.WebApi.csproj"
COPY . .
WORKDIR "/src/SourdoughBakery.WebApi"
RUN dotnet build "SourdoughBakery.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SourdoughBakery.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SourdoughBakery.WebApi.dll"]