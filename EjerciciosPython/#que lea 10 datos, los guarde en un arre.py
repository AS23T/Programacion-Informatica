#que lea 10 datos, los guarde en un arreglo A, lea 10 datos y los guarde en un arreglo B, calcule y guarde en un arreglo C la resta de los arreglos A-B, imprimir el arreglo de los resultados

A = []
B = []

for i in range(10):
    A.append(float(input(f"Ingrese el dato de A {i+1}: ")))

for i in range(10):
     B.append(float(input(f"Ingrese el dato de B {i+1}: ")))
     
C = [(A[i] - B[i]) for i in range (10)]

print("\nArreglo A:")
print(",".join([f"{n}" for n in A]))

print("\nArreglo B:")
print(",".join([f"{n}" for n in B]))

print("\nArreglo C, la resta de A y B:")
print(",".join([f"{n}" for n in C]))