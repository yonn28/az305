
# identity and security

![alt text](image-221.png)

![alt text](image-222.png)

![alt text](image-223.png)

privilege identity management (adicionar los roles pero en modo "elegibility" para que el se los auto asigne en el Privilege identity management)

![alt text](image-224.png)

invitar usuarios externos

![alt text](image-225.png)

# access reviews de permisos en Entra ID

![alt text](image-228.png)

![alt text](image-226.png)

```
https://myapps.microsoft.com/

```

![alt text](image-227.png)

# identity protection

![alt text](image-229.png)


![alt text](image-230.png)


![alt text](image-231.png)



# azure Blueprints

![alt text](image-232.png)


# azure acces control

![alt text](image-233.png)

# manage identities

![alt text](image-234.png)


# azure key vault

![alt text](image-235.png)



# application proxy

![alt text](image-236.png)


![alt text](image-237.png)

![alt text](image-238.png)


# autorization and authentication

![alt text](image-239.png)

![alt text](image-240.png)


# multifactor autentication

![alt text](image-241.png)

![alt text](image-242.png)

![alt text](image-243.png)

validar los metodos de autenticacion de informacion disponibles

![alt text](image-244.png)

# enterprice aplicaiotions para (single sing on)

![alt text](image-245.png)


![alt text](image-246.png)


![alt text](image-247.png)

permisos para poder acceder a la informacion de esta enterprice application,. en este caso la API de graph

![alt text](image-248.png)


# conditional access policies

![alt text](image-249.png)




# Bussines Contrinuity

creacion del server y de la db

![alt text](image-154.png)

utilizar el script sql

```
CREATE TABLE [logdata]
(
        [Id] int,
        [Operationname] [varchar](200) NULL,
	[Status] [varchar](100) NULL,
	[Eventcategory] [varchar](100) NULL,
	[Resourcetype] [varchar](1000) NULL,
        [Resource] [varchar](2000) NULL
)
```

generacion de data

copiar la cadena de conexion y ejecutar el archivo (dejar ejecutar hasta cuantos registros se quiera)

![alt text](image-155.png)


![alt text](image-156.png)

conceptos clave

![alt text](image-157.png)

la base de datos guarda todos los eventos que se han ejecutado en la bd

![alt text](image-158.png)

![alt text](image-159.png)


# azure database backup

![alt text](image-160.png)

![alt text](image-161.png)

![alt text](image-162.png)


maximo 35 dias de retencion de los backups

![alt text](image-163.png)

para el caso de restaurar la base de datos dar click aqui

![alt text](image-164.png)

se abre este menu configurando el punto de restauracion, se puede obtener una base de datos nueva configurada con el RTO (retention Time objetive) maximo de 10 minutos

![alt text](image-165.png)


# sql database redundancy

![alt text](image-166.png)

# link para backups

`https://learn.microsoft.com/en-us/azure/azure-sql/database/troubleshoot-common-connectivity-issues?view=azuresql`


# active geo replication

![alt text](image-168.png)

![alt text](image-169.png)

![alt text](image-170.png)

![alt text](image-171.png)

![alt text](image-172.png)

![alt text](image-173.png)

![alt text](image-174.png)

primero adicionar la ip para que se pueda conectar a la bd

![alt text](image-175.png)

![alt text](image-176.png)

![alt text](image-177.png)

![alt text](image-178.png)

la idea es tener una replica de la base de datos que se actualicé continuamente (en modo readonly)

![alt text](image-179.png)

# failover bd

![alt text](image-180.png)

![alt text](image-181.png)


# auto-failover 

no hay necesidad de cambiar la cadena de conexion entre los failover ya que existe un listener que ayuda con esta gestion internamente.

![alt text](image-182.png)

![alt text](image-183.png)


# auto-failover groups

crear una base de datos nueva en el mismo servidor

![alt text](image-184.png)

adicionar la ip que tenemos actualmente en la session de networking

![alt text](image-185.png)

additional settings

adicionar la opcion de sample

![alt text](image-186.png)

crear la base de datos

![alt text](image-187.png)

crear una base de datos para adicionarla a el failover group

![alt text](image-189.png)


![alt text](image-190.png)

![alt text](image-188.png)

cambiar la localizacion de la creacion de la base de datos secundaria

![alt text](image-191.png)


usar autenticacion de password y usuario

![alt text](image-192.png)

permitir que otros servicios de azure accedan a este recurso

![alt text](image-193.png)

![alt text](image-194.png)

ir a la base de datos y adicionar el nuevo motor creado en una zona diferente

![alt text](image-195.png)


![alt text](image-196.png)

![alt text](image-197.png)

![alt text](image-198.png)

![alt text](image-199.png)

seleccionar las bases de datos

![alt text](image-200.png)

![alt text](image-201.png)

ir a la base de datos secundaria y adicionar la ip que se tiene actualmente para poder conectarse

![alt text](image-202.png)

![alt text](image-203.png)

![alt text](image-204.png)

copiar la direccion del servidor

![alt text](image-205.png)


conectarse con sql management

![alt text](image-206.png)

![alt text](image-207.png)


configuracion del listener del failover group

![alt text](image-208.png)

![alt text](image-209.png)

![alt text](image-210.png)


![alt text](image-211.png)

![alt text](image-212.png)


actualizar la cadena de connexion

![alt text](image-213.png)

validar la cantidad de registos en la bd

![alt text](image-214.png)

crear la tabla primero para poder ejecutar el codigo

![alt text](image-215.png)

escribir algunos registros utilizando la cadena de failover group

![alt text](image-216.png)

![alt text](image-217.png)

forzar el failover

![alt text](image-218.png)

![alt text](image-219.png)

se genera un pequeña interrupcion en el servicio mientras este cambio sucede



review of the sql database

![alt text](image-220.png)



---

## Azure batch

![alt text](image-150.png)

![alt text](image-151.png)

![alt text](image-152.png)

![alt text](image-153.png)



## conectivity onpremise site-to-site, and point-to-site (azure virtual network gateway)

![alt text](image-3.png)

![alt text](image.png)

![alt text](image-1.png)

![alt text](image-2.png)

![alt text](image-4.png)

![alt text](image-5.png)

generar point to site configuration

![alt text](image-9.png)

se necesita tener un certificado generado localmente para poder hacer la conexion

![alt text](image-10.png)

generacion del certificado en la maquina point

![alt text](image-6.png)

![alt text](image-7.png)

![alt text](image-8.png)

![alt text](image-11.png)

![alt text](image-12.png)

![alt text](image-13.png)

browse dar nombre y guardar el certificado

![alt text](image-14.png)

![alt text](image-15.png)

![alt text](image-16.png)

abrir con vscode

![alt text](image-17.png)

![alt text](image-18.png)

copiar

![alt text](image-19.png)


pegar y guardar

![alt text](image-20.png)

esperar a que se guarde

![alt text](image-22.png)

descargar el cliente

![alt text](image-21.png)

![alt text](image-23.png)

descomprimir

![alt text](image-24.png)

![alt text](image-25.png)

![alt text](image-26.png)

ya con esta configuracion de VPN ya se puede acceder usando la ip privada de los recursos (no se realizo por problemas de permisos en el equipo)

## virtual wan

solucion para cuando site-to-site se vuelve muy complejo, ya que se tienen muchas subredes, y cada una con un vitual network gateway

![alt text](image-27.png)

se usa un expressroute 

![alt text](image-28.png)

## load balancer

![alt text](image-48.png)

![alt text](image-49.png)

## aplication gateway

![alt text](image-29.png)

![alt text](image-30.png)

![alt text](image-31.png)

![alt text](image-32.png)

![alt text](image-33.png)

![alt text](image-34.png)

![alt text](image-35.png)

![alt text](image-36.png)

![alt text](image-37.png)


![alt text](image-38.png)


![alt text](image-39.png)

![alt text](image-40.png)

![alt text](image-41.png)

![alt text](image-42.png)

![alt text](image-43.png)

![alt text](image-44.png)

![alt text](image-45.png)

![alt text](image-46.png)

![alt text](image-47.png)

![alt text](image-50.png)

![alt text](image-51.png)

![alt text](image-52.png)

## front door como CDN

![alt text](image-53.png)

## front door como balanceador de carga

![alt text](image-56.png)


## redis cache

![alt text](image-54.png)

![alt text](image-55.png)

## event hubs

![alt text](image-57.png)


![alt text](image-58.png)

![alt text](image-59.png)

![alt text](image-60.png)

![alt text](image-81.png)

se crea el namespace pero se necesita crear un event hub

![alt text](image-61.png)

![alt text](image-62.png)

![alt text](image-63.png)

con los codigos de envio y recepcion 

![alt text](image-65.png)

descargar las contraseñas de accesos

![alt text](image-64.png)

![alt text](image-66.png)

crear politica de acceso
![alt text](image-67.png)

sacar connection string

![alt text](image-68.png)

![alt text](image-69.png)

![alt text](image-70.png)

recibir eventos

![alt text](image-71.png)

![alt text](image-72.png)

![alt text](image-73.png)

![alt text](image-74.png)

![alt text](image-75.png)

![alt text](image-76.png)

cleanup policy: no es para guardar data

![alt text](image-77.png)

![alt text](image-78.png)

para hacer persistente los datos y realizar procesamiento de ellos, para guardarlos se usa storage accounts y analizar a posterior

![alt text](image-79.png)

![alt text](image-80.png)

## Azure Functions

![alt text](image-82.png)

## lab scenario

![alt text](image-83.png)

![alt text](image-84.png)

![alt text](image-85.png)

generar el hub, y validar que hub este haciendo backup hacia el storage account.

![alt text](image-91.png)

cambiar la cadena de conexion en la function corriendo local para que escuche los eventos del event hub.

![alt text](image-87.png)

![alt text](image-88.png)

![alt text](image-89.png)

borrar la parte de entitie path

![alt text](image-90.png)

cambiar el nombre del event hub

![alt text](image-92.png)

Crear un app service y en el diagnose settings enviar la informacion al nuevo event hub

![alt text](image-93.png)

![alt text](image-94.png)

![alt text](image-95.png)

guardar y validar

![alt text](image-96.png)

generar trafico en el sitio

![alt text](image-97.png)

![alt text](image-98.png)

colocando la function a correr actualizando la version a la mas reciente se pueden validar los eventos generados 

![alt text](image-101.png)

Crear un cosmosDb (noSql) para enviar los logs del eventhub desde la function

![alt text](image-99.png)

![alt text](image-100.png)

con el uso de data explorer generar un nuevo container a donde mandar los logs del hub

![alt text](image-102.png)

en el segundo proyecto que tiene conexion con cosmos para function actualizar la cadena del hub y el nombre del hub

![alt text](image-103.png)


![alt text](image-104.png)

crear el container en cosmosDB

![alt text](image-105.png)

![alt text](image-106.png)

![alt text](image-107.png)

actualizar la cadena de connecion del codigo

![alt text](image-108.png)

tener en cuenta que cuando se crea pide un nombre de bd, y un nombre de container, por eso el nombre de la bd NO!! es el nombre de la cuenta de cosmos db

![alt text](image-109.png)

![alt text](image-110.png)

codigo funcionando desde local funcion

![alt text](image-111.png)

![alt text](image-113.png)

desplegar la function

![alt text](image-112.png)


## Azure service Bus

storage account al cual se le suben archivos, y se guarda la informacion en un contenedor no procesado y se genera un evento en el service bus, despues con otro codigo se leen los mensajes y se procesa guardando un registro en la bd de cosmosDB

![alt text](image-114.png)


![alt text](image-115.png)


## logic apps

![alt text](image-116.png)

![alt text](image-117.png)

![alt text](image-118.png)

![alt text](image-119.png)

![alt text](image-120.png)

![alt text](image-121.png)

![alt text](image-122.png)

![alt text](image-123.png)

adicionar eror en imgagen es la connection string y el nombre del storage account

![alt text](image-124.png)

![alt text](image-125.png)

![alt text](image-126.png)

![alt text](image-127.png)

![alt text](image-128.png)

adicionar una accion

![alt text](image-129.png)

![alt text](image-130.png)

![alt text](image-131.png)

despues de creada la conexion hacia la cuenta de outlook con las contraseñas pedidas

![alt text](image-132.png)

se pueden adicionar los valores del evento que lo genero

![alt text](image-133.png)

![alt text](image-134.png)

![alt text](image-135.png)

![alt text](image-136.png)

ya llegan las notificaciones de actualizacion 

![alt text](image-137.png)

# Event Grid

crear una function

![alt text](image-139.png)

se puede suscribir a los eventos de un storage account

![alt text](image-138.png)



# Api Management

![alt text](image-140.png)

# migration patterns

![alt text](image-141.png)

# Microsoft Cloud Adoption Framework

![alt text](image-142.png)

![alt text](image-143.png)

# data transfer options to azure 

![alt text](image-144.png)

# azCopy tool

![alt text](image-146.png)

``` azcopy copy "my-local-data" "https://mystorageaccount.blob.core.windows.net/my-container/?<your_sas_token>" --recursive ```


## azure data studio (migracion de dbs, crear configuracion y descargar agente en la VM objetivo)

![alt text](image-147.png)

![alt text](image-148.png)

![alt text](image-149.png)

![alt text](image-145.png)