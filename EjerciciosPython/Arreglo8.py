#Que lea 10 numeros, los ordene y muestre ordenados de menor a mayor.

A = []

print("Ingresa 10 numeros para el arreglo A:")
for i in range(10):
    A.append(float(input(f"A;{i+1}: ")))

# Funcion para ordenar el arreglo A de menor a mayor (se puede usar "sort(reverse=True)" para mayor a menor)
A.sort(reverse=False)

print("Arreglo A ordenado de menor a mayor:")
print(" | ".join([f"{n}" for n in A]))