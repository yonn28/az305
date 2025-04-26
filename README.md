

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