#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/services/PlanningBet.Users.API/PlanningBet.Users.API.csproj", "src/services/PlanningBet.Users.API/"]
RUN dotnet restore "src/services/PlanningBet.Users.API/PlanningBet.Users.API.csproj"
COPY . .
WORKDIR "/src/src/services/PlanningBet.Users.API"
RUN dotnet build "PlanningBet.Users.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlanningBet.Users.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlanningBet.Users.API.dll"]