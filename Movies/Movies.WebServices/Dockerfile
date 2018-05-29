FROM microsoft/wcf:4.7.1
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .
