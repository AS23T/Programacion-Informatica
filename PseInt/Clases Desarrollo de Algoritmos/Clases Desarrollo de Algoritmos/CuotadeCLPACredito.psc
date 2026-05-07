Proceso CuotadeCLPACreditoUF
	Definir creditoUF, NCuotas, valorUF, cuota_UF, cuota_CLP Como Real;
	Leer creditoUF;
	Leer NCuotas;
	Leer valorUF;
	cuota_UF <- creditoUF/NCuotas;
	cuota_CLP <- cuota_UF*valorUF;
	Escribir cuota_CLP;
FinProceso
