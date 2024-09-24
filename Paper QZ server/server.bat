@echo off

rem Ensure this Node.js and npm are first in the PATH
set "PATH=%APPDATA%\npm;%~dp0;%PATH%"

setlocal enabledelayedexpansion
pushd "%~dp0"

rem Figure out the Node.js version.
set print_version=.\node.exe -p -e "process.versions.node + ' (' + process.arch + ')'"
for /F "usebackq delims=" %%v in (`%print_version%`) do set version=%%v

rem Print message.
if exist npm.cmd (
  echo Your environment has been set up for using Node.js !version! and npm.
) else (
  echo Your environment has been set up for using Node.js !version!.
)

popd
endlocal

rem If we're in the Node.js directory, change to the user's home dir.
if "%CD%\"=="%~dp0" cd /d "%HOMEDRIVE%%HOMEPATH%" && powershell Add-Type -AssemblyName PresentationFramework; [System.Windows.MessageBox]::Show('Please enter this link in your paper qzz andoid app form your android phone for print and this link and after restart this server or after 7 days Revisit link and Re-enter this password', 'How to and Important info', [System.Windows.MessageBoxButton]::OK, [System.Windows.MessageBoxImage]::Information) 
lt --port 8181 