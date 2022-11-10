FROM mcr.microsoft.com/dotnet/aspnet:5.0

# Label version= is now set by semantic-release
ARG BUILD_VERSION="1.0.0"
ENV ApiVersion=$BUILD_VERSION

ARG source
WORKDIR /app
EXPOSE 8430
COPY ${source:-bin/Release/net5.0/publish/} .
ENTRYPOINT ["dotnet", "TomShirley.EFCore.Sample.Endpoint.dll"]
