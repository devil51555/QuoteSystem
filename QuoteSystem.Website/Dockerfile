FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["QuoteSystem.Website/QuoteSystem.Website.csproj", "QuoteSystem.Website/"]
RUN dotnet restore "QuoteSystem.Website/QuoteSystem.Website.csproj"
COPY . .
WORKDIR "/src/QuoteSystem.Website"
RUN dotnet build "QuoteSystem.Website.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "QuoteSystem.Website.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "QuoteSystem.Website.dll"]