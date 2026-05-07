print("CalcularElIMC")

masa = float(input("Ingrese su masa: "))
estatura = float(input("Ingrese su estatura: "))

IMC = masa / (estatura*estatura)

print(f"El IMC de su persona es: {IMC:.2f}")