print("CalcularCentimetrosAPies")

cm = float(input("Ingrese la longitud en centimetros: "))
while cm < 0:
    print("Ingrese un valor positivo.")
    cm = float(input("Ingrese la longitud en centimetros: "))

pies = cm / 30.48
print(f"{cm} cm equivalen a {pies:.2f} pies.")