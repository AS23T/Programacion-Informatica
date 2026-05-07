#Matrices

filas = int(input("Ingrese número de filas: "))
columnas = int(input("Ingrese número de columnas: "))

matriz = []

# Llenar la matriz con datos del usuario
for f in range(filas):
    fila = []
    for c in range(columnas):
        valor = int(input(f"Ingrese el valor para la posición [{f}][{c}]: "))
        fila.append(valor)
    matriz.append(fila)

# Imprimir matriz de derecha a izquierda
print("\nMatriz impresa de derecha a izquierda:")
for f in range(filas):
    for c in range(columnas - 1, -1, -1):  # recorre de derecha a izquierda
        print(matriz[f][c], end=' ')
    print()
