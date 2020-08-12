FROM mcr.microsoft.com/mssql/server:2017-latest-ubuntu

EXPOSE 1433
ENV ACCEPT_EULA=Y SA_PASSWORD=teste123 MSSQL_PID=Express

CMD /bin/bash ./entrypoint.sh
