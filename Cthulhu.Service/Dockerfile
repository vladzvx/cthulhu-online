#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Cthulhu.Service/Cthulhu.Service.csproj", "Cthulhu.Service/"]
COPY ["Cthulhu.CoreLib/Cthulhu.CoreLib.csproj", "Cthulhu.CoreLib/"]
RUN dotnet restore "Cthulhu.Service/Cthulhu.Service.csproj"
COPY . .
WORKDIR "/src/Cthulhu.Service"
RUN dotnet build "Cthulhu.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cthulhu.Service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cthulhu.Service.dll"]
