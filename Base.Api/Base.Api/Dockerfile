FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY Base.Api/Base.Api.csproj Base.Api/
RUN dotnet restore "Base.Api/Base.Api.csproj"
COPY . .
WORKDIR "/src/Base.Api"
RUN dotnet build "Base.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Base.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Base.Api.dll"]
