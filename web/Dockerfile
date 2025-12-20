FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000
RUN mkdir -p /app/data

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TransactsWeb.csproj", "."]
RUN dotnet restore "TransactsWeb.csproj"
COPY . .
RUN dotnet build "TransactsWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TransactsWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:5000
ENV DOTNET_RUNNING_IN_CONTAINER=true
ENTRYPOINT ["dotnet", "TransactsWeb.dll"]