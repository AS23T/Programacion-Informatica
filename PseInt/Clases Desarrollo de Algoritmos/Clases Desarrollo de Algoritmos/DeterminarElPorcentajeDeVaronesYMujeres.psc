Proceso DeterminarElPorcentajeDeVaronesYMujeres
	Definir varones, mujeres, Total, PorcVarones, PorcMujeres Como Real;
	Leer varones;
	Leer mujeres;
	Total <- varones + mujeres;
	PorcVarones <- (varones/Total)*100;
	PorcMujeres <- (mujeres/Total)*100;
	Escribir PorcVarones;
	Escribir PorcMujeres;
FinProceso
