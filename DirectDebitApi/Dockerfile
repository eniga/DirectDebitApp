FROM mcr.microsoft.com/dotnet/aspnet:5.0

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY *.csproj ./DirectDebitApi/
RUN dotnet restore

# copy everything else and build app
COPY . ./DirectDebitApi/
WORKDIR /app/DirectDebitApi
RUN dotnet publish -C Release -o out



ENTRYPOINT ["dotnet", "DirectDebitApi.dll"]