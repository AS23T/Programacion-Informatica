Proceso PromedioVersion2
	Definir num1, num2, num3, Prom Como Real;
	Definir c Como Entero;
	c <- 0;
	Repetir
		Leer num1;
		Leer num2;
		Leer num3;
		c <- c+1;
		Prom <- (num1+num2+num3)/3;
		Escribir Prom;
	Hasta Que c=20
	
FinProceso
