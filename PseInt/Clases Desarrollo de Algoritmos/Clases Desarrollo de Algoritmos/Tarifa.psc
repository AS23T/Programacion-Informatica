Proceso Tarifa
	Definir N, total, minExtra Como Real;
	Leer N;
	Si N<=20 Entonces
		total <- 366;
	SiNo
		minExtra <- N-20;
		total <- 366+minExtra*18.28;
		Escribir total;
	FinSi
	
FinProceso
