FROM mcr.microsoft.com/mssql/server:2017-latest-ubuntu

EXPOSE 1433
ENV ACCEPT_EULA=Y SA_PASSWORD=Q!w2E#r4 MSSQL_PID=Express

WORKDIR /
COPY ["src/ListaSupermercado.API/Docker/entrypoint.sh", "/"]
COPY ["src/ListaSupermercado.API/Docker/run-initialization.sh", "/src/"]
COPY ["src/ListaSupermercado.API/Docker/setup.sql", "/"]

CMD [ "/bin/bash", "entrypoint.sh" ]