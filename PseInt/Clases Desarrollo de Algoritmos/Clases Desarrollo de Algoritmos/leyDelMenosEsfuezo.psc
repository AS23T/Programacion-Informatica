Proceso leyDelMenosEsfuezo
	Definir total, porcMini, asistMini, faltPerm Como Real;
	total <- 12;
	porcMini <- 0.70;
	asistMini <- (total * porcMini);
	// Si asistMini no es entero, lo redondeamos hacia arriba (Simular Ceil)
	Si Trunc(asistMini) <> asistMini Entonces
		asistMini <- Trunc(asistMini) + 1;
	Sino
		asistMini <- Trunc(asistMini);
	FinSi
	faltPerm <- total-asistMini;
	Escribir faltPerm;
	
FinProceso
