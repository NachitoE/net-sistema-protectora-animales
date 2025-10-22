@echo off
setlocal
pushd "%~dp0"

echo =====================================================
echo [INFO] Este script usa 'dotnet-ef'.
echo Si no lo tenes instalado globalmente:
echo     dotnet tool install --global dotnet-ef
echo -----------------------------------------------------
echo Si ya lo instalaste, asegurate de reiniciar la consola.
echo =====================================================
echo.

REM ==============================
REM Si se pasa "clean" como primer argumento -> borrar migraciones previas
REM ==============================

echo ===============================
echo Borrando todas las migraciones previas...
echo ===============================
if exist "Infrastructure.Data\Migrations" (
	rmdir /s /q "Infrastructure.Data\Migrations"
	echo [OK] Carpeta de migraciones eliminada.
) else (
	echo [WARN] No se encontró carpeta de migraciones.
)
shift


REM ==============================
REM Generar timestamp yyyyMMdd_HHmmss
REM ==============================
for /f %%I in ('powershell -NoProfile -Command "(Get-Date).ToString('yyyyMMdd_HHmmss')"') do set "stamp=%%I"

REM ==============================
REM Nombre base opcional (param 1). Ej:
REM migracion.bat LoginFix -> LoginFix_20251014_161500
REM migracion.bat clean LoginFix -> borra migraciones + LoginFix_20251014_161500
REM ==============================
set "baseName=AddMigration"
if not "%~1"=="" set "baseName=%~1"
set "migrationName=%baseName%_%stamp%"

echo ===============================
echo Eliminando base de datos...
echo ===============================
dotnet ef database drop -f -p "Infrastructure.Data" -s "WebAPI" -f
if errorlevel 1 goto :fail

echo ===============================
echo Creando migracion %migrationName%...
echo ===============================
dotnet ef migrations add "%migrationName%" -p "Infrastructure.Data" -s "WebAPI"
if errorlevel 1 goto :fail

echo ===============================
echo Actualizando base de datos...
echo ===============================
dotnet ef database update -p "Infrastructure.Data" -s "WebAPI"
if errorlevel 1 goto :fail

echo ===============================
echo Listo! Migración creada: %migrationName%
echo ===============================
goto :end

:fail
echo [ERROR] Algo falló. Revisá el log anterior.

:end
popd
pause
