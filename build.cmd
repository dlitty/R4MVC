@echo off
cd %~dp0

SETLOCAL ENABLEEXTENSIONS
SET CACHED_NUGET=%LocalAppData%\NuGet\NuGet.exe

IF EXIST %CACHED_NUGET% goto copynuget
echo Downloading latest version of NuGet.exe...
IF NOT EXIST %LocalAppData%\NuGet md %LocalAppData%\NuGet
@powershell -NoProfile -ExecutionPolicy unrestricted -Command "$ProgressPreference = 'SilentlyContinue'; Invoke-WebRequest 'https://www.nuget.org/nuget.exe' -OutFile '%CACHED_NUGET%'"

:copynuget
IF EXIST .nuget\nuget.exe goto restore
md .nuget
copy %CACHED_NUGET% .nuget\nuget.exe > nul

:restore
IF EXIST packages\KoreBuild goto run
.nuget\NuGet.exe install KoreBuild -ExcludeVersion -o packages -nocache -pre -Source https://www.myget.org/F/aspnetvnext/api/v2
.nuget\NuGet.exe install Sake -version 0.2 -o packages -ExcludeVersion 

IF "%SKIP_KRE_INSTALL%"=="1" goto run
CALL packages\KoreBuild\build\kvm upgrade -runtime CLR -x86
CALL packages\KoreBuild\build\kvm install default -runtime CoreCLR -x86

:run
CALL packages\KoreBuild\build\kvm use default -runtime CLR -x86
CALL packages\KoreBuild\build\kpm restore
CALL packages\KoreBuild\build\kvm build

:end
exit /b %ERRORLEVEL%
