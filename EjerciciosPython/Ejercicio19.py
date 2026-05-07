print("CalcularElSueldoNetoDeUnVendedorSabiendoQueHizoTresVentasEnElMes")

sueldoBasico = float(input("Ingrese el sueldo basico del vendedor: "))

V1 = float(input("Ingrese el valor de la primera venta: "))
V2 = float(input("Ingrese el valor de la segunda venta: "))
V3 = float(input("Ingrese el valor de la tercera venta: "))

totalV = V1 + V2 + V3

comision = totalV * 0.12

sueldoNeto = sueldoBasico + comision

print(f"\nEl sueldo neto del vendedor es de: ${sueldoNeto:,.2f}")