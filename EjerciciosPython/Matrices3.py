#Matrices

columnas = 3
filas = 6
matriz = []

for f in range(filas - 1, -1, -1):  # desde la última fila hasta la primera
    for c in range(columnas):
        print(matriz[f][c], end=' ')
    print()
