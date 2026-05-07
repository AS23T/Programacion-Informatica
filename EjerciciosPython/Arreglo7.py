#Que lea 10 numeros, los guarde en un arreglo A, y luego los traspase al reves
#a un arreglo B, imprima los dos arreglos

A = []
B = []

a = 10
b = 9

for i in range(a):
    A.append(float(input(f"Ingrese el dato, vamos en {i+1}: ")))

for i in range(a):
    B.append(A[b - i])  # Traspasar los elementos de A a B en orden inverso

print("\nArreglo A:")
print(" | ".join([f"{n}" for n in A]))
print("\nArreglo B, los elementos de A al reves:")
print(" | ".join([f"{n}" for n in B]))
