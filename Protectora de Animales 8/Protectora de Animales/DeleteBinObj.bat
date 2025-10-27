@echo off
echo ===============================
echo Eliminando carpetas bin y obj (nivel actual)...
echo ===============================

setlocal enabledelayedexpansion
set count=0

REM Recorre todas las subcarpetas en el directorio actual
for /d %%d in (*) do (
    if exist "%%d\bin" (
        echo Eliminando %%d\bin
        rmdir /s /q "%%d\bin"
        set /a count+=1
    )
    if exist "%%d\obj" (
        echo Eliminando %%d\obj
        rmdir /s /q "%%d\obj"
        set /a count+=1
    )
)

echo ===============================
echo Se eliminaron !count! carpetas bin/obj.
echo ===============================
pause
