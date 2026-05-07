Proceso Inicio
	
	Definir arreglo, indice Como Entero;
	
	dimension arreglo(5);
	
	arreglo(0) <- 1;
	arreglo(1) <- 2;
	arreglo(2) <- 3;
	arreglo(3) <- 4;
	arreglo(4) <- 5;
	
	Escribir arreglo(1);
	
	Para indice<-0 Hasta 4 Con Paso 1 Hacer
		Escribir arreglo(indice);
	FinPara
	
	Para indice<-0 Hasta 4 Con Paso 1 Hacer
		Escribir "Dame el nuevo valor de la posicion", indice;
		Leer arreglo(indice);
	FinPara
	
	Para indice<-0 Hasta 4 Con Paso 1 Hacer
		Escribir arreglo(indice);
	FinPara
	
FinProceso
