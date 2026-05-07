#Matrices

filas = 6
columnas = 3
matriz = []

for f in range(filas - 1, -1, -1):  # filas de abajo a arriba
    for c in range(columnas - 1, -1, -1):  # columnas de derecha a izquierda
        print(matriz[f][c], end=' ')
    print()
