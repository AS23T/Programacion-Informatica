#Matrices

filas = 6
columnas = 3
matriz = []
contador = 1

for f in range(filas):
    fila = []
    for c in range(columnas):
        fila.append(contador)
        contador += 1
    matriz.append(fila)  # Rellenar con números consecutivos (puede ser reverso tambien con -= 1)

print("\nMATRIZ INGRESADA:")
for fila in matriz:
    print("|", end=" ")
    for elemento in fila:
        print(elemento, end=" | ")
    print()
