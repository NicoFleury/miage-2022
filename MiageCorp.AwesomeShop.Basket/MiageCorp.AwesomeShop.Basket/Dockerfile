#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MiageCorp.AwesomeShop.Basket/MiageCorp.AwesomeShop.Basket.csproj", "MiageCorp.AwesomeShop.Basket/"]
RUN dotnet restore "MiageCorp.AwesomeShop.Basket/MiageCorp.AwesomeShop.Basket.csproj"
COPY . .
WORKDIR "/src/MiageCorp.AwesomeShop.Basket"
RUN dotnet build "MiageCorp.AwesomeShop.Basket.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MiageCorp.AwesomeShop.Basket.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiageCorp.AwesomeShop.Basket.dll"]