# Stage 1 - Restoring & Compiling
FROM microsoft/dotnet:2.1-sdk-alpine3.7 as builder
WORKDIR /source
RUN apk add --update nodejs nodejs-npm
COPY *.csproj .
RUN dotnet restore
COPY package.json .
RUN npm install
COPY . .
RUN dotnet publish -c Release -o /app/

# Stage 2 - Creating Image for compiled app
FROM microsoft/dotnet:2.1.1-aspnetcore-runtime-alpine3.7 as baseimage
RUN apk add --update nodejs nodejs-npm
WORKDIR /app
COPY --from=builder /app .
ENV ASPNETCORE_URLS=http://+:$port

# Run the application. REPLACE the name of dll with the name of the dll produced by your application
EXPOSE $port
CMD ["dotnet", "test13.dll"]
