#Matrices

filas = 6
columnas = 3
matriz = []

for f in range(filas):
    for c in range(columnas - 1, -1, -1):  # desde la última columna a la primera
        print(matriz[f][c], end=' ')
    print()
