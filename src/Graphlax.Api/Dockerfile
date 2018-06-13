#build container
FROM microsoft/dotnet:2.0-sdk AS build-env

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o out

#live code container
FROM microsoft/dotnet:2.0-runtime

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet","Graphlax.Api.dll"]
