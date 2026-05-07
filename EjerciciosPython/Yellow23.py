# Leer 15 números, guardarlos en un arreglo A, calcular promedio, mayor y menor

A = []

for i in range(15):
    num = float(input(f"Ingrese el número {i+1}: "))
    A.append(num)

promedio = sum(A) / len(A)
mayor = max(A)
menor = min(A)

print(f"Arreglo A: {A}")

print(f"Promedio: {promedio}")

print(f"Mayor: {mayor}")

print(f"Menor: {menor}")
