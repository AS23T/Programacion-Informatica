print("CalcularLaCantidadDeTasasDeTé")

litros = float(input("Ingrese la cantidad de litros de té: "))

if litros < 0:
    print("Error: No se puede ingresar un valor negativo")
else:
    aguaCC = litros * 1000

    tazas = int(aguaCC / 200)

    print (f"Se pueden servir {tazas} tazas de té de 200cc")