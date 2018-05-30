FROM microsoft/aspnet:4.6.2
EXPOSE 80
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .