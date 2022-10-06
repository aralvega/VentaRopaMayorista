![logo_GlicoCare](https://github.com/aralvega/VentaRopaMayorista/blob/main/imagenes/COTIZADOR.png)

### Tópicos 

- [Descripcion del proyecto](#descripcion-del-proyecto)

- [Funcionalidades](#funcionalidades)

- [Modelado](#modelado)

- [Patrón MVP](#patron-mvp)

- [Acceso al proyecto](#acceso-al-proyecto)

- [Abrir y ejecutar el proyecto](#abrir-y-ejecutar-el-proyecto)

- [Desarrollador](#desarrollador)

## Descripcion del proyecto 

<p align="justify">
 En esta aplicación se sumula la cotización de 2 tipos de prendas antes de su posterior venta. Se puede vsualizar el listado de prendas disponibles, ingresar diferentes parámetros que modifican el precio final por unidad de prenda, calcular el total de cotización y finalmente la posibilidad de visualizar las cotizaciones realizadas.

![Pantalla de la aplicacion.](https://github.com/aralvega/VentaRopaMayorista/blob/main/imagenes/aplicacion.png)
</p>

## Funcionalidades

:heavy_check_mark: `Funcionalidad 1:` Consulta de prendas almacenadas en base de datos.

:heavy_check_mark: `Funcionalidad 2:` Cálculo de la cotización final de cada prenda en base a un conjunto de parámetros:
- R1. Si la camisa es de manga corta se rebaja el precio un 10%
- R2. Si la camisa es cuello mao aumenta el precio un 3%
- R3. Si la camisa es manga corta y cuello mao se aplican las dos reglas anteriores en ese orden.
- R4. Si el pantalón es chupin, se rebaja el precio un 12%
- R5. Si la calidad es standard no se modifica el precio
- R6. Si la calidad es premium se aumenta el precio en un 30%

:heavy_check_mark: `Funcionalidad 3:` Calcula el precio total de cotización y lo visualiza en pantalla. Además registra la cotización en una lista

:heavy_check_mark: `Funcionalidad 4:` Consulta de las cotizaciones realizadas.

:heavy_check_mark: `Funcionalidad 4:` Validación de campos.

## Modelado

<div align="center">

![Diagrama de clases](https://github.com/aralvega/VentaRopaMayorista/blob/main/imagenes/DiagramaClases.png)

  </div>
  
<div align="center">

![Modelo físico de base de datos](https://github.com/aralvega/VentaRopaMayorista/blob/main/base%20de%20datos/diagrama%20fisico.png)

  </div>
  
 <p align="justify">
 - En la carpeta base de datos se encuentra el modelo para ser ejecutado en MySQL Workbench y generar el script de la tabla.
 - En la carpeta mysql-connector-net-5.2.7-noinstall está el driver para conectarse a la base de datos. En Visual studio hay que configurar la referencia al archivo mysql.data.dll

###

## Patron MVP

</div>
  
<div align="center">

![Patrón MVP](https://github.com/aralvega/VentaRopaMayorista/blob/main/imagenes/patronMVPS.png)

  </div>

###

## Acceso al proyecto

Ud puede [acceder al código del proyecto aqui](https://github.com/aralvega/VentaRopaMayorista.git) y descargarlo dentro del botón CODE.

## Abrir y ejecutar el proyecto

Despues de bajar y descomprimir el proyecto utilice Visual Studio Community 2019 🏆 

## Desarrollador

| <sub>Ariel Alejandro Vega</sub>](https://github.com/aralvega) |
| :---: | :---: | :---: | :---: 
