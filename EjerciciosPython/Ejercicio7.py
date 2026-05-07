print("CalcularUnaCuotaCLPACreditoUF")

UF = 39055.90 # valor que cambia con el tiempo

cuota_UF = int(input("Ingrese el valor del credito en UF: "))

cuota_CLP = UF * cuota_UF

print(f"El valor de la cuota en pesos (CLP) es: {cuota_CLP:.2f} CLP")