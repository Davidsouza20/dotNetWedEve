# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview
WORKDIR /app
COPY --from=build /out .
ENV ASPNETCORE_URLS=http://+:5222
EXPOSE 5222
ENTRYPOINT ["dotnet", "dotNetWedEve.dll"]
