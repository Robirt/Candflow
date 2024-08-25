FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Candflow.WebAPI/Candflow.WebAPI.csproj", "Candflow.WebAPI/"]
RUN dotnet restore "./Candflow.WebAPI/Candflow.WebAPI.csproj"
COPY . .
WORKDIR "/src/Candflow.WebAPI"
RUN dotnet build "./Candflow.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Candflow.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Candflow.WebAPI.dll"]