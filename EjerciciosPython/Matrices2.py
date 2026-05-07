#Matrices

filas = 6
columnas = 3

matriz = []

for f in range(filas):
    fila = []
    for c in range(columnas):
        fila.append(0)
    matriz.append(fila)

# Imprimir la matriz como tabla
for fila in matriz:
    for elemento in fila:
        print(elemento, end=' ')
    print()  # Salto de línea después de cada fila
