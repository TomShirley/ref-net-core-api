FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine
RUN apk --no-cache update && \
    apk --no-cache add nodejs npm && \
    rm -rf /var/cache/apk/*
RUN npm install -g npm nswag@^13.6.0
ENTRYPOINT [ "nswag" ]
CMD [ "help" ]
