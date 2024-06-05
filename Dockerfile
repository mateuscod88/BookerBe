FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Booker.API/Booker.API.csproj", "Booker.API/"]
COPY ["Booker.Infrastructure/Booker.Infrastructure.csproj", "Booker.Infrastructure/"]
COPY ["Booker.Application/Booker.Application.csproj", "Booker.Application/"]
COPY ["Booker.Domain/Booker.Domain.csproj", "Booker.Domain/"]
RUN dotnet restore "Booker.API/Booker.API.csproj"
COPY . .
WORKDIR "/src/Booker.API"
RUN dotnet build "Booker.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Booker.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Booker.API.dll"]
