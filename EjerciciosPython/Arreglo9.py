#en arreglo C lea 10 numeros, los guarde en un arreglo A, verifique
#si son pares o impares, los pares los guarde en un arreglo llamado PAR,
#y los impares en uno llamado IMPAR, Imprimir los arreglos A, PAR e IMPAR.

A = []
C = []

PAR = []
IMPAR = []

for i in range(10):
    A.append(int(input(f"Ingrese el dato como N° Entero {i+1}: ")))
    
for i in range(10):
    C.append(A[i])
    if C[i] % 2 == 0:
        PAR.append(C[i])
    else:
        IMPAR.append(C[i])

print("\nArreglo A:")
print(" | ".join([f"{n}" for n in A]))

print("\nArreglo PAR:")
print(" | ".join([f"{n}" for n in PAR]))

print("\nArreglo IMPAR:")
print(" | ".join([f"{n}" for n in IMPAR]))
