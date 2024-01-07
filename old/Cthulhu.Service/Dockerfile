FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cthulhu.Service/Cthulhu.Service.csproj", "Cthulhu.Service/"]
RUN dotnet restore "Cthulhu.Service/Cthulhu.Service.csproj"
COPY . .
WORKDIR "/src/Cthulhu.Service"
RUN dotnet build "Cthulhu.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cthulhu.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cthulhu.Service.dll"]