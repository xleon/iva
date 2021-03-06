[![NuGet](https://img.shields.io/nuget/v/net.xleon.iva.svg?style=for-the-badge)](https://www.nuget.org/packages/net.xleon.iva/) 
[![NuGet](https://img.shields.io/nuget/dt/net.xleon.iva.svg?style=for-the-badge)](https://www.nuget.org/packages/net.xleon.iva/)
 
# Calculador de IVA / IRPF

Línea de comandos para calcular IVA / IRPF a partir de la base imponible.

# Instalación

Asegúrate de tener [dotnet core](https://dotnet.microsoft.com/download) instalado

Para instalar el programa de forma global en tu máquina, solo hay que ejecutar el siguiente comando en la consola:
   
 ```console
 dotnet tool install -g net.xleon.iva
 ```  

# Uso

Simple:

```console
$ iva 1000

Base imponible: 1000 €
I.V.A (21%): 210 €
Total a facturar: 1210 €
Neto: 1000 €
```

Con IRPF por defecto (15%):

```console
$ iva 1500 -i

Base imponible: 1500 €
I.V.A (21%): 315 €
I.R.F.F (15%): -225 €
Total a facturar: 1590 €
Neto: 1275 €
```

Con IRPF personalizado (le pasamos un 7%):

```console
$ iva 1500 -i 7

Base imponible: 1500 €
I.V.A (21%): 315 €
I.R.F.F (7%): -105 €
Total a facturar: 1710 €
Neto: 1395 €
```

# Actualizar

Una vez instalado puedes actualizar el paquete a la última versión con:

```console
dotnet tool update -g net.xleon.iva
```

# Desinstalar

```console
dotnet tool uninstall -g net.xleon.iva
```
