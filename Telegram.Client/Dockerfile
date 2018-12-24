FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Telegram.Client/Telegram.Client.csproj", "Telegram.Client/"]
RUN dotnet restore "Telegram.Client/Telegram.Client.csproj"
COPY . .
WORKDIR "/src/Telegram.Client"
RUN dotnet build "Telegram.Client.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Telegram.Client.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Telegram.Client.dll"]