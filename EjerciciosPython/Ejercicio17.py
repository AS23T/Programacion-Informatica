print("CalcularElMontoEnEurosACadaMonto")

soles = float(input("Ingrese la cantidad de soles a donar: "))
dolares = float(input("Ingrese la cantidad de dolares a donar: "))
marcos = float(input("Ingrese la cantidad de marcos a donar: "))

solesDolares = soles / 3.52

marcosDolares = marcos / 2.08

totalDolares = dolares + solesDolares + marcosDolares

totalEuros = totalDolares * 1.07

salud = totalEuros * 0.60
comedor = totalEuros * 0.30
admin = totalEuros * 0.10

print(f"\nTotal en euros: {totalEuros:,.2f}")
print(f"Centro de salud (60%): {salud:,.2f}")
print(f"Comedor (30%): {comedor:,.2f}")
print(f"Administrador (10%): {admin:,.2f}")