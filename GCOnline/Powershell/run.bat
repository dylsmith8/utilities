@ECHO OFF

tasklist /FI "IMAGENAME eq snarl.exe" 2>NUL | find /I /N "snarl.exe">NUL

if "%ERRORLEVEL%"=="0" (
	echo Snarl is running
	echo ============================
) else (
	cd "C:\Program Files (x86)\full phat"
	start snarl.exe
)

cd C:\Working\Products\GhostConvey\dotNET\GhostConveyOnline\App\Build
grunt 

PAUSE