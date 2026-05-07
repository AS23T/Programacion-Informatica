Proceso MontoQueDebePagar
	Definir valorUF, ustedPaga, aseguradora_Paga, deducible Como Real;
	Leer valorUF;
	deducible <- 5*valorUF;
	Si deducible>=678987 Entonces
		ustedPaga <- 678987;
		aseguradora_Paga <- 0;
	SiNo
		ustedPaga <- deducible;
		aseguradora_Paga <- 678987-deducible;
	FinSi
	Escribir ustedPaga;
	Escribir aseguradora_Paga;
FinProceso
