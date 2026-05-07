print("Calculadora de IMC")

masa = float(input("Ingrese su masa en kg: "))
while masa <= 0 or masa > 500:
    print("Error: La masa debe estar entre 0 y 500kg(500000g)")
    masa = float(input("Ingrese su masa en kg: "))

estatura = float(input("Ingrese su estatura en cm: "))
while estatura <= 0 or estatura > 250:
    print("Error: La estatura debe estar entre 0 y 250cm(2.5m)")
    estatura = float(input("Ingrese su estatura en cm: "))

estaturaM = estatura / 100 # Conversor de CM a M

IMC = masa / (estaturaM * estaturaM)

print(f"El IMC de su persona es: {IMC:.2f}")