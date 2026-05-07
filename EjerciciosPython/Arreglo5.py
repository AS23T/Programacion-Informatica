#En C que lea 10 numeros, los guarde en un arreglo A, luego lea otros 10 numeros, los guarde
#en un arreglo B, sume los numeros y guarde el resultado en un arreglo C. Imprima los 3 arreglos

# Listas
A = []
B = []
C = []

# Solicitar al usuario que ingrese 10 números para el arreglo A
print("Ingrese 10 numeros para el arreglo A:")
for i in range(10):
    A.append(float(input(f"A;{i+1}: ")))

# Solicitar al usuario que ingrese 10 números para el arreglo B
print("Ingrese 10 numeros para el arreglo B:")
for i in range(10):
    B.append(float(input(f"B;{i+1}: ")))

# Sumar los elementos de A y B en el mismo rango y guardarlos en el arreglo C
for i in range(10):
    C.append(A[i] + B[i])

# Imprimir los arreglos A, B y de C
print("Arreglo A:", A)
print("Arreglo B:", B)
print("Arreglo C, A mas B:", C)
