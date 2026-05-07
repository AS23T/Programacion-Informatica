Proceso SueldoNetoVenta
	Definir sueldoBasico, V1, V2, V3, totalV, comision, sueldoNeto Como Real;
	Leer sueldoBasico;
	Leer V1;
	Leer V2;
	Leer V3;
	totalV <- V1+V2+V3;
	comision <- totalV*0.12;
	sueldoNeto <- sueldoBasico+comision;
	Escribir sueldoNeto;
FinProceso
