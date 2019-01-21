FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Core.Web/Core.Web.csproj", "Core.Web/"]
COPY ["Core.MSTests/Core.MSTests.csproj", "Core.MSTests/"]
COPY ["Core.Services/Core.Services.csproj", "Core.Services/"]
COPY ["Core.Models/Core.Models.csproj", "Core.Models/"]
COPY ["Core.Contracts/Core.Contracts.csproj", "Core.Contracts/"]
COPY ["CoreTemplate.sln", "./"]
RUN dotnet restore

COPY . .

WORKDIR /src/Core.Web
RUN dotnet build "Core.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Core.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Core.Web.dll"]