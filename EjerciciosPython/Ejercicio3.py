print("CalcularLongitudDePiesACentimetros")

pies = float(input("Ingrese la longitud en pies: "))
while pies < 0:
    print("Ingrese un valor positivo.")
    pies = float(input("Ingrese la longitud en pies: "))

cm = pies * 30.48
print(f"{pies} pies equivalen a {cm:.2f} cm.")