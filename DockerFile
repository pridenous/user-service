# Gunakan image resmi Microsoft .NET 8.0 sebagai base image untuk runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Gunakan SDK .NET 8.0 untuk build aplikasi
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["user-service/user-service.csproj", "user-service/"]
RUN dotnet restore "user-service/user-service.csproj"
COPY . .
WORKDIR "/src/user-service"
RUN dotnet build "user-service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "user-service.csproj" -c Release -o /app/publish

# Create final image with the app built
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "user-service.dll"]