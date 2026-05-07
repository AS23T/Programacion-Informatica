print("CalcularCostoCLPDePanQueContieneNKG")

precioKG = float(input("Ingrese el precio por KG (en CLP): "))

pesoKG = float(input("Ingrese el peso en KG (en kg): "))

if pesoKG < 0 or precioKG < 0:
    print("Error, no se puede ingresar un valor negativo")
else:
    costo = pesoKG * precioKG

    print(f"El costo total es: CLP {costo:.2f}")