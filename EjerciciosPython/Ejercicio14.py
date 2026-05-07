print("ElMontoQueAsumeLaAseguradoraYLoQueDebePagarUno")

valor_UF = 39055.90
deducible = 5
dCLP = deducible * valor_UF
costo = 678987

if costo > dCLP:
    usted_paga = dCLP
    aseguradora_paga = costo - dCLP
else:
    usted_paga = costo
    aseguradora_paga = 0

print(f"\nEl costo total del accidente es: CLP {costo:,.0f}")
print(f"Valor del deducible (5 UF): CLP {dCLP:,.0f}")
print(f"La aseguradora paga: CLP {aseguradora_paga:,.0f}")
print(f"Usted paga: CLP {usted_paga:,.0f}")