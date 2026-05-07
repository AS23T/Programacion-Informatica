#Matrices

filas = 6
columnas = 3
matriz = []

for i in range(min(filas, columnas)):
    print(matriz[i][columnas - 1 - i], end=' ')
print()  # Imprimir un salto de línea al final
