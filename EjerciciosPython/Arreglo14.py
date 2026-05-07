#Hacer un programa en C que lea datos desde el teclado, valide si los datos son pares o impares, los guarde en un arreglo PAR o IMPAR respectivamente, luego sume los datos de ambos arreglos (PAR[i]+IMPAR[i]) y los guarde en un arreglo A. La cantidad de datos va estar determinada por el ingreso del usuario, cuando el ingrese un 33 o un multiplo de 33.

PAR = []
IMPAR = []
A = []

while True:
    num = int(input("Ingrese un numero (terminar con 33 o un multiplo de 33): "))

    if num != 0 and num % 33 == 0:
        print("Numero multiplo de 33 ingresado. Fin del ingreso.")
        break

    if num % 2 == 0:
        PAR.append(num)
    else:
        IMPAR.append(num)

# Determinar cuántos elementos se pueden sumar (mínimo entre las dos listas)
min_len = min(len(PAR), len(IMPAR))

# Sumar PAR[i] + IMPAR[i] y guardar en A
for i in range(min_len):
    suma = PAR[i] + IMPAR[i]
    A.append(suma)

# Mostrar resultados
print("\n Arreglo PAR ")
for i in range(len(PAR)):
    print(f"PAR[{i}] = {PAR[i]}")

print("\n Arreglo IMPAR ")
for i in range(len(IMPAR)):
    print(f"IMPAR[{i}] = {IMPAR[i]}")

print("\n Arreglo A (suma PAR[i] + IMPAR[i]) ")
for i in range(len(A)):
    print(f"A[{i}] = {A[i]}")
