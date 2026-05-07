print("CalcularElCostoTotalDeUnTrabajoEnUnJardinDeNM2")

Nm2 = float(input("Ingrese los metros cuadrados a calcular: "))

while Nm2 < 0:
    print("El valor debe ser mayor a 0")
    Nm2 = float(input("Ingrese los metros cuadrados a calcular: "))

costoSemillas = 5000
costoAbono = 2000
costoManoObra = 30000

costoTotalm2 = costoSemillas + costoAbono + costoManoObra
costoTotal = costoTotalm2 * Nm2

print(f"\nCosto por m2: {costoTotalm2:,.0f} CLP")
print(f"Area total: {Nm2} m2")
print(f"Costo total: {costoTotal:,.0f} CLP")