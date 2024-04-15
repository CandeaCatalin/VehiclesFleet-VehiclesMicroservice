FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["VehiclesMicroservice/VehiclesMicroservice.csproj", "VehiclesMicroservice/"]
COPY ["VehiclesMicroservice.Domain/VehiclesMicroservice.Domain.csproj", "VehiclesMicroservice.Domain/"]
COPY ["VehiclesMicroservice.BusinessLogic/VehiclesMicroservice.BusinessLogic.csproj", "VehiclesMicroservice.BusinessLogic/"]
COPY ["VehiclesMicroservice.Repository/VehiclesMicroservice.Repository.csproj", "VehiclesMicroservice.Repository/"]
COPY ["VehiclesMicroservice.DataAccess/VehiclesMicroservice.DataAccess.csproj", "VehiclesMicroservice.DataAccess/"]
COPY ["VehiclesMicroservice.DI/VehiclesMicroservice.DI.csproj", "VehiclesMicroservice.DI/"]
COPY ["VehiclesMicroservice.Services/VehiclesMicroservice.Services.csproj", "VehiclesMicroservice.Services/"]
COPY ["VehiclesMicroservice.Settings/VehiclesMicroservice.Settings.csproj", "VehiclesMicroservice.Settings/"]
RUN dotnet restore "VehiclesMicroservice/VehiclesMicroservice.csproj"
COPY . .
WORKDIR "/src/VehiclesMicroservice"
RUN dotnet build "VehiclesMicroservice.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "VehiclesMicroservice.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VehiclesMicroservice.dll"]
