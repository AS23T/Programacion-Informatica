#Matrices

filas = int(input("¿Cuantas filas tendra la matriz? "))
columnas = int(input("¿Cuantas columnas tendra la matriz? "))

matriz = []

print("\nIngresa los elementos fila por fila:")
for f in range(filas):
    fila = []
    for c in range(columnas):
        num = int(input(f"Ingrese el elemento [{f}][{c}]: "))
        fila.append(num)
    matriz.append(fila)

# Imprimir la matriz como tabla
print("\nLa matriz ingresada:")
for fila in matriz:
    print("|", end=" ")
    for elemento in fila:
        print(f"{elemento:3}", end=" ")
    print("|")
