Proceso VelocidadPromedioDeUnAtleta
	Definir min, seg, cent, distM Como Entero;
	Leer min;
	Leer seg;
	Leer cent;
	Leer distM;
	Definir tiempoSeg, tiempoHrs, distKM, velocidad Como Real;
	tiempoSeg <- (min*60)+seg+(cent/100);
	tiempoHrs <- tiempoSeg/3600;
	distKM <- distM/1000;
	velocidad <- distKM/tiempoHrs;
	Escribir "La velocidad es: ", velocidad, " km/h";
	
FinProceso
