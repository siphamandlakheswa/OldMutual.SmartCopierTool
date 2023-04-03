FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/OldMutual.SmartCopierTool.Web.Host/OldMutual.SmartCopierTool.Web.Host.csproj", "src/OldMutual.SmartCopierTool.Web.Host/"]
COPY ["src/OldMutual.SmartCopierTool.Web.Core/OldMutual.SmartCopierTool.Web.Core.csproj", "src/OldMutual.SmartCopierTool.Web.Core/"]
COPY ["src/OldMutual.SmartCopierTool.Application/OldMutual.SmartCopierTool.Application.csproj", "src/OldMutual.SmartCopierTool.Application/"]
COPY ["src/OldMutual.SmartCopierTool.Core/OldMutual.SmartCopierTool.Core.csproj", "src/OldMutual.SmartCopierTool.Core/"]
COPY ["src/OldMutual.SmartCopierTool.EntityFrameworkCore/OldMutual.SmartCopierTool.EntityFrameworkCore.csproj", "src/OldMutual.SmartCopierTool.EntityFrameworkCore/"]
WORKDIR "/src/src/OldMutual.SmartCopierTool.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/OldMutual.SmartCopierTool.Web.Host", "src/OldMutual.SmartCopierTool.Web.Host"]
COPY ["src/OldMutual.SmartCopierTool.Web.Core", "src/OldMutual.SmartCopierTool.Web.Core"]
COPY ["src/OldMutual.SmartCopierTool.Application", "src/OldMutual.SmartCopierTool.Application"]
COPY ["src/OldMutual.SmartCopierTool.Core", "src/OldMutual.SmartCopierTool.Core"]
COPY ["src/OldMutual.SmartCopierTool.EntityFrameworkCore", "src/OldMutual.SmartCopierTool.EntityFrameworkCore"]
WORKDIR "/src/src/OldMutual.SmartCopierTool.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "OldMutual.SmartCopierTool.Web.Host.dll"]
