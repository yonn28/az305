# Variables
$SqlInstallerUrl = "https://go.microsoft.com/fwlink/?linkid=866658"  # SQL Server 2019 Developer Edition Web Installer
$InstallerPath = "$env:TEMP\SQL2019.exe"
$ConfigurationFilePath = "$env:TEMP\ConfigurationFile.ini"

# Descargar instalador
Invoke-WebRequest -Uri $SqlInstallerUrl -OutFile $InstallerPath

# Crear archivo de configuración para instalación desatendida
@"
[OPTIONS]
ACTION="Install"
FEATURES=SQLENGINE
INSTANCENAME="MSSQLSERVER"
SECURITYMODE=SQL
SAPWD="StrongP@ssw0rd!"
SQLSVCACCOUNT="NT AUTHORITY\NETWORK SERVICE"
SQLSYSADMINACCOUNTS="Administrators"
AGTSVCACCOUNT="NT AUTHORITY\NETWORK SERVICE"
IACCEPTSQLSERVERLICENSETERMS="True"
TCPENABLED=1
NPENABLED=1
"@ | Out-File -Encoding ASCII -FilePath $ConfigurationFilePath

# Ejecutar la instalación
Start-Process -Wait -FilePath $InstallerPath -ArgumentList "/ConfigurationFile=$ConfigurationFilePath /Q"