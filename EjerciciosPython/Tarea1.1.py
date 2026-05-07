# programa que calcule el IMC con todas los calculos correspondientes (de forma completa), max 2.5M (en CM es 150, conversión de unidades) de altura y 500kg (en g es 500.000, conversión de unidades) de peso (en KG)
# con bucles whiles o For
print("Calculadora de IMC")

masa = 0
estatura = 0

while True:
    try:
        masa = float(input("Ingrese su masa en kg: "))
        if 0 < masa <= 500: # Comparador de masa para sus limites
            break
        print("Error: La masa debe estar entre 0 y 500kg(500000g)")
    except ValueError:
        print("Error: Ingrese un número válido")

while True:
    try:
        estatura = float(input("Ingrese su estatura en cm: "))
        if 0 < estatura <= 250: # Comparador de estatura para sus limites
            break
        print("Error: La estatura debe estar entre 0 y 250cm(2.5m)")
    except ValueError:
        print("Error: Ingrese un número válido")

estaturaM = estatura / 100 # Conversor de CM a M
IMC = masa / (estaturaM * estaturaM)

print(f"El IMC de su persona es: {IMC:.2f}")
