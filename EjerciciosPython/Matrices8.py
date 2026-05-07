#Matrices

filas = 6
columnas = 3
matriz = []

#Mostrar valores en diagonal principal (cuando la matriz es cuadrada o te limitas al tamaño mínimo entre filas y columnas)
for i in range(min(filas, columnas)):
    print(matriz[i][i], end=' ')
print()  # Nueva línea después de imprimir la diagonal principal
