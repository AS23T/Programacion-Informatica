print("CalcularTarifaQueDebeCancelarEnParquimetro")

Nminutos = float(input("Ingrese los minutos que ha pasado en el parqueo: "))

while Nminutos <0:
    print("El valor ingresado no es correcto")
    Nminutos = float(input("Ingrese los minutos que ha pasado en el parqueo: "))

tarifaBase = 366
tarifaAdicional = 18.28

if Nminutos <= 20:
    total = tarifaBase
else:
    minExtra = Nminutos - 20
    total = tarifaBase + (minExtra * tarifaAdicional)

print(f"\nMinutos parqueado: {Nminutos}")
print(f"Total a pagar: CLP {total:,.2f}")