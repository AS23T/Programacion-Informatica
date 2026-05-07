Ejercicio 1
CREATE TABLE productos (
    COD_PRODUCTO NUMBER(6) NOT NULL, un largo de 6 digitos
    DES_PRODUCTO VARCHAR2(40) NOT NULL, tendra un largo de 40 caracteres
    PRIMARY KEY (COD_PRODUCTO) Declaramos la llave primaria que identifica la clase/tabla productos
)


El lenguaje SQL ignora mayusculas y minusculas, no es sensible a ellas
y tambien ignora el orden horizontal y vertical

Ejercicio 2
insert into productos (COD_PRODUCTO, DES_PRODUCTO)
values (1000, 'COMPUTADOR HP X3')

Ejercicio 3
insert into productos (COD_PRODUCTO, DES_PRODUCTO)
values (10001, 'PANTALLA HPZR2240w')

Ejercicio 4 (seleccionamos todos de mi tabla productos, ayuda a visualizar si no me acuerdo)
select *
from productos

Ejercicio 5 (seleccionamos solo DES_PRODUCTO de mi tabla productos)
select DES_PRODUCTO from productos

Ejercicio 6
CREATE TABLE CLIENTE (
    RUT VARCHAR2(10) NOT NULL,
    NOMBRE VARCHAR2(40) NOT NULL,
    DIRECCION VARCHAR2(40) NOT NULL,
    COMUNA VARCHAR2(40) NOT NULL,
    PRIMARY KEY (RUT)
)

insert into CLIENTE (RUT, NOMBRE, DIRECCION, COMUNA)
values ('1234567890', 'Jose Andres Rivales', 'Leonera', 'Puente Alto')

select *
from CLIENTE
*/

Ejercicio 7
SELECT * FROM EMPLEADO

WHERE ID_DEPTO = 20

SELECT * FROM EMPLEADO

WHERE NOMBRE = 'FORD'

Ejercicio 8
SELECT DISTINCT COUNT(*) FROM EMPLEADO

SELECT DISTINCT CARGO, COUNT(*) FROM EMPLEADO GROUP BY CARGO

SELECT DISTINCT CARGO, COUNT(*) as Cuantos FROM EMPLEADO GROUP BY CARGO

Ejercicio 9
SELECT NRO_CRE, VALOR, VALOR*1.19 "VALOR CON IVA" FROM CREDITO

SELECT NRO_CRE, VALOR, VALOR+10 AS SUMA FROM CREDITO

Ejercicio 10
SELECT NRO_CRE, ((VALOR * 10) + 2) AS RESULTADO FROM CREDITO

Ejercicio 11
ALTER TABLE CREDITO ADD COMISION NUMBER(6,2) //investigar NUMBER(XXX,XXX) que hace

Ejercicio 12
select valor, valor*comision as resultado from credito

Ejercicio 13
select * 
from empleado
where nombre ='JONES' or NOMBRE = 'SMITH'

Ejercicio 14
SELECT * FROM EMPLEADO 
WHERE NOMBRE = 'JONES' AND ID_DEPTO = 20

Ejercicio 15
SELECT * FROM CREDITO
WHERE VALOR>= 250000 AND VALOR <= 750000

//UPDATE & DELETE siempre con WHERE

Ejercicio 16
SELECT * FROM CREDITO
WHERE VALOR in (250000,750000)

SELECT * FROM CREDITO
WHERE valor = 250000 or valor = 750000

//Actuan igual, el OR y el IN

Ejercicio 17
SELECT ID_EMP, CONCAT(CARGO, 'ES EL CARGO DEL COLABORADOR') || nombre "Descripcion" from empleado

SELECT CONCAT(nombre, ' ', apellido) AS NombreCompleto FROM usuarios;

Ejercicio 18
SELECT nro_cre, id_emp, valor as credito, (valor * 0.5) as Descuento from credito

Ejercicio 19
SELECT NOMBRE || ' ' || CARGO AS NOMBRE_Y_CARGO 
FROM EMPLEADO

SELECT NOMBRE || ' ' || CARGO "NOMBRE Y CARGO"
FROM EMPLEADO

Ejercicio 20
SELECT *
FROM EMPLEADO E, DEPTO D
WHERE E.ID_DEPTO = D.ID_DEPTO

SELECT E.ID_EMP, E.NOMBRE, D.NOM_DEPTO
FROM EMPLEADO E, DEPTO D //Le asigno el Alias E y D a la tabla Empleado y Depto
WHERE E.ID_DEPTO = D.ID_DEPTO //Donde se van a poner e igualar y pone E y D en sus respectivos atributos

//Las variables de SQL son los Alias, para poder definir identificadores no visibles
//SQL hace busquedas secuenciales

Ejercicio 21
ERROR:
insert into empleado (id_emp, id_depto, nombre, cargo)
values (1000, 80,'Ignacio Munoz', 'Analista')

SOLUCION:
insert into DEPTO
values (80, 'ANALISTA')

Ejercicio 22
UPDATE DEPTO
SET NOM_DEPTO = 'OFIMATICA'
WHERE ID_DEPTO = 80

Ejercicio 23
insert into empleado (id_emp, id_depto, nombre, cargo)
values (2000, 80,'KEVIN VAZQUEZ', 'ANALISTA')

delimitar literales de cadena de texto (strings) y valores de fecha/hora en las consultas
Clave, las comillas simples (') son para datos, mientras que las comillas dobles (") o comillas invertidas (`) suelen reservarse para identificadores (nombres de tablas o columnas)

Ejercicio 24
SELECT E.ID_EMP, E.NOMBRE, D.NOM_DEPTO
FROM EMPLEADO E, DEPTO D
WHERE E.ID_DEPTO = D.ID_DEPTO and (e.id_emp = 1000 or e.id_emp = 2000)

Ejercicio 25
SELECT ID_EMP, NOMBRE, CARGO
FROM EMPLEADO
WHERE CARGO = UPPER('analista')

Ejercicio 26
SELECT ID_EMP, NOMBRE, CARGO
FROM EMPLEADO
WHERE ID_DEPTO = 10

Ejercicio 27
select id_emp, nombre, cargo
from empleado
where id_depto = 10 or
      ID_DEPTO = 20

Ejercicio 28
select id_emp, nombre, cargo, id_depto
from empleado
where id_depto in (10,20)

Ejercicio 29
UPDATE CREDITO
SET COMISION = 0.3
WHERE NRO_CRE = 1004

Ejercicio 30
select * from credito 
where comision > 0

Ejercicio 31
select id_emp, id_depto, nombre
from empleado
where id_depto not in (10)

Ejercicio 32
select *
from credito
order by valor, fecha desc/asc

Ej 33
select nro_cre, id_emp, valor, to_char(fecha, 'DD/MM/YYYY')
from credito
order by valor, fecha desc

Ej 34
select nro_cre, id_emp, valor, to_char(fecha, 'DD/MM/YYYY')
from credito
where id_emp = 7839

BETWEEN ES INCLUYENTE

Ej 35
select nro_cre, id_emp, valor, to_char(fecha, 'DD/MM/YYYY')
from credito
where VALOR NOT BETWEEN 500000 AND 950000

select *
from nls_session_parameters (nls - National Language Support)
Muestra pares de Parámetro (PARAMETER) y Valor (VALUE) que afectan cómo se muestran los datos (fechas, números, moneda) y cómo se comportan las comparaciones de texto en tu sesión actual, que está activa actualmente para la sesión de usuario

Ej 36
select nro_cre, id_emp, valor, fecha 
from credito
where fecha between '21-mar-2025' and '04-aug-2025'
order by fecha asc 

Ej 37
select nro_cre, id_emp, valor, fecha 
from credito
where to_char(fecha, 'MM-YYYY')= '08-2025'
order by fecha asc

Ej 38
select NOMBRE, ID_EMP
from empleado
WHERE NOMBRE LIKE '__R%'

Ej 37
select NOMBRE, ID_EMP
from empleado
WHERE NOMBRE LIKE '%A%E%'

Ej 38
select *
from empleado e, depto d
where d.id_depto = e.id_depto

//Todo esto es para relacionar tablas con sus PK y FK con un alias para identificarlas como variable

select e.id_emp, e.nombre, d.nom_depto
from empleado e, depto d
where d.id_depto = e.id_depto


select e.id_emp, e.nombre, d.nom_depto
from empleado e, depto d
where d.id_depto = e.id_depto AND
	e.cargo = 'ANALISTA'

Ej 39
DESC crédito

Ej 40
select e.id_emp, e.nombre, d.nom_depto, e.cargo, cr.fecha, cr.valor
from empleado e, depto d, crédito cr
where d.id_depto = e.id_depto AND cr.id_emp = e.id_emp

Ej 41
SELECT * FROM EMPLEADO
WHERE ID_EMP NOT IN (SELECT ID_EMP FROM CREDITO)

//muestro la relaciones que no tienen con la tabla crédito por PK a FK en el ID

Ej 42
SELECT * FROM CREDITO
WHERE ID_EMP = 7698

//Le entrego un valor a la tabla para listar, si tiene crédito o no, relacionados por PK a FK

Ej 43
SELECT * FROM EMPLEADO
WHERE ID_EMP IN (1000, 7499)

Ej 44
SELECT ID_EMP FROM CREDITO

Ej 45
SELECT * FROM EMPLEADO
WHERE ID_EMP IN (SELECT ID_EMP FROM CREDITO)

//muestro la relaciones que si tienen con la tabla crédito por PK a FK en el ID

Ej 46
SELECT NOMBRE, LENGTH(NOMBRE) AS LARGO
FROM EMPLEADO

Ej 47
SELECT NOMBRE, SUBSTR(NOMBRE, 1, 4) AS USUARIO