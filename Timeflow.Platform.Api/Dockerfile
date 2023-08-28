#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Timeflow.Platform.Api/Timeflow.Platform.Api.csproj", "Timeflow.Platform.Api/"]
RUN dotnet restore "Timeflow.Platform.Api/Timeflow.Platform.Api.csproj"
COPY . .
WORKDIR "/src/Timeflow.Platform.Api"
RUN dotnet build "Timeflow.Platform.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Timeflow.Platform.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Timeflow.Platform.Api.dll"]