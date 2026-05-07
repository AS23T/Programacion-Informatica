Proceso EnTresRubros
	Definir soles, dolares, M, solesDolares, MDolares, totalDolares, totalEuros, salud, comedor, admin Como Real;
	Leer soles;
	Leer dolares;
	Leer M;
	solesDolares <- soles/3.52;
	MDolares <- M/2.08;
	totalDolares <- solesDolares+dolares+MDolares;
	totalEuros <- totalDolares*1.07;
	salud <- totalEuros*0.60;
	comedor <- totalEuros*0.30;
	admin <- totalEuros*0.10;
	Escribir salud;
	Escribir comedor;
	Escribir admin;
FinProceso
