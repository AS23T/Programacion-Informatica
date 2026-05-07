SubProceso doblarPorReferencia ( n Por Referencia)
	n <- n* 2;
FinSubProceso

SubProceso resultado <- doblarPorValor ( n )
	Definir resultado Como Entero;
	
	resultado <- n* 2;
FinSubProceso

Proceso Inicio
	
	Definir a,b Como Entero;
	
	Escribir "Dame un valor para a";
	Leer a;
	
	Escribir "Dame un valor para b";
	Leer b;
	
	doblarPorReferencia(a);
	Escribir a;
	
	b <- doblarPorValor(b);
	Escribir b;
	
FinProceso
