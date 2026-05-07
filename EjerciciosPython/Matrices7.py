#Matrices

filas = 4
columnas = 4
matriz = []

print("Ingrese los valores para una matriz de 4x4:")

# Llenar la matriz con datos del usuario
for f in range(filas):
    fil = []
    for c in range(columnas):
        valor = int(input(f"Ingrese el valor para la posición Fila: [{f}] {f+1} Columna: [{c}] {c+1}: "))
        fil.append(valor)
    matriz.append(fil)

# Mostrar la matriz ingresada (opcional)
print("\nMatriz ingresada:")
for fila in matriz:
    for elemento in fila:
        print(f"{elemento:4}", end=' ')
    print()

# Consultar posiciones
while True:
    print("\nConsulta de posición (escriba -1 para salir)")
    filaUsuario = int(input("Ingrese número de fila (0 a 3): "))
    if filaUsuario == -1:
        break
    columnaUsuario = int(input("Ingrese número de columna (0 a 3): "))
    if columnaUsuario == -1:
        break

    if 0 <= filaUsuario < filas and 0 <= columnaUsuario < columnas:
        print(f"La matriz[{filaUsuario}][{columnaUsuario}] es: {matriz[filaUsuario][columnaUsuario]}")
    else:
        print("Posición fuera de rango. Intente denuevo.")
