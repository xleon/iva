Calculador de IVA / IRPF
---

Pequeño script creado para probar las nuevas "global tools" de dotnet.

## Instalación

Asegúrate de tener [dotnet 2.1+](https://www.microsoft.com/net/learn/get-started/windows) instalado

Para instalar el programa de forma global en tu máquina, solo hay que ejecutar el siguiente comando en la consola:
    
    dotnet tool install --global net.xleon.iva

## Uso

Simple:

```
$ iva 1000

Base imponible: 1000 €
I.V.A (21%): 210 €
Total a facturar: 1210 €
Neto: 1000 €
```

Con IRPF por defecto (15%):

```
$ iva 1500 -i

Base imponible: 1500 €
I.V.A (21%): 315 €
I.R.F.F (15%): -225 €
Total a facturar: 1590 €
Neto: 1275 €
```

Con IRPF personalizado (le pasamos un 7%):

```
$ iva 1500 -i 7

Base imponible: 1500 €
I.V.A (21%): 315 €
I.R.F.F (7%): -105 €
Total a facturar: 1710 €
Neto: 1395 €
```
