Proceso Inicio
	
	Definir arreglo, fila, columna Como Entero;
	
	
	dimension arreglo(3,3);
	
	Para fila<-0 Hasta 2 Con Paso 1 Hacer
		Para columna<-0 Hasta 2 Con Paso 1 Hacer
			Escribir "Escribe un valor para la fila ", fila, " y la columna ", columna;
			Leer arreglo(fila, columna);
		FinPara
	FinPara
	
	Para fila<-0 Hasta 2 Con Paso 1 Hacer
		Para columna<-0 Hasta 2 Con Paso 1 Hacer
			Escribir arreglo(fila, columna), " " Sin Saltar;
		FinPara
		Escribir "";
	FinPara
	
FinProceso
