Proceso SueldoLiquidoElementos
	Definir sueldoBase, fondoPension, fondoSalud, descuentoPension, descuentoSalud, sueldoLiquido Como Real;
	Escribir "Ingrese el sueldo base como valor";
	Leer sueldoBase;
	Escribir "Ingrese el fondo de pension en porcentaje";
	Leer fondoPension;
	Escribir "Ingrese el fondo de salud en porcentaje";
	Leer fondoSalud;
	descuentoPension <- sueldoBase*(fondoPension/100);
	descuentoSalud <- sueldoBase*(fondoSalud/100);
	sueldoLiquido <- sueldoBase-descuentoPension-descuentoSalud;
	Escribir sueldoLiquido;
FinProceso
