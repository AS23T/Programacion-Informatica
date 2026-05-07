print("CalcularPromedioDeNotas")

certamen1 = float(input("Ingrese la nota del primer certamen: "))
certamen2 = float(input("Ingrese la nota del segundo certamen: "))
test = float(input("Ingrese la nota del test: "))

prom = (certamen1 * 0.4) + (certamen2 * 0.4) + (test * 0.2)

print(f"Su promedio de notas es: {prom:.1f}")