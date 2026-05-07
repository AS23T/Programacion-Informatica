SubProceso saludar
	Escribir "Hola";
	
FinSubProceso

SubProceso resultado <- doble (n)
	
	Definir resultado Como Entero;
	
	resultado <- n * 2;
	
FinSubProceso

Proceso sin_titulo
	
	saludar();
	
	Definir a, b Como Entero;
	
	Escribir "Dame un valor";
	Leer a;
	
	b <- doble(a);
	Escribir b;
	
	
FinProceso
