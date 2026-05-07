print("CalcularElSueldoLiquido")

sueldoBase = float(input("Ingrese el sueldo base (en CLP): "))
fondoPension = float(input("Ingrese el porcentaje de pension: "))
fondoSalud = float(input("Ingrese el porcentaje de salud: "))

while sueldoBase<0 or fondoPension<0 or fondoSalud<0:
    print("Error, el valor no puede ser negativo")
    sueldoBase = float(input("Ingrese el sueldo base (en CLP): "))
    fondoPension = float(input("Ingrese el porcentaje de pension: "))
    fondoSalud = float(input("Ingrese el porcentaje de salud: "))

descuentoPension = sueldoBase * (fondoPension / 100)
descuentoSalud = sueldoBase * (fondoSalud / 100)

sueldoLiquido = sueldoBase - descuentoPension - descuentoSalud

print(f"Sueldo base: {sueldoBase:,.2f} CLP")
print(f"La pension ({fondoPension}%): {descuentoPension:,.2f} CLP")
print(f"La salud ({fondoSalud}%): {descuentoSalud:,.2f} CLP")
print(f"El sueldo liquido es: {sueldoLiquido:,.2f} CLP")