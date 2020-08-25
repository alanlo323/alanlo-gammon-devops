FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["alanlo-gammon-devops/alanlo-gammon-devops.csproj", "alanlo-gammon-devops/"]
RUN dotnet restore "alanlo-gammon-devops/alanlo-gammon-devops.csproj"
COPY . .
WORKDIR "/src/alanlo-gammon-devops"
RUN dotnet build "alanlo-gammon-devops.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "alanlo-gammon-devops.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "alanlo-gammon-devops.dll"]