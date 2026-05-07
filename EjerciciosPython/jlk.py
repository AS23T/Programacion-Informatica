#Para poder comprobar que sabe manejar matrices se le solicita a usted que

#cree una matriz de 4x4
filas = 4
columnas = 4
matriz = []

#ingrese datos enteros entre 30 y 80 en la matriz
for f in range(filas):
    a = []
    for c in range(columnas):
        valor = int(input(f"Ingrese un valor entero entre 30 y 80 para la posicion, (fila: {f+1}, columna: {c+1}): "))
        while valor < 30 or valor > 80:
            print("Valor fuera de rango, debe ser entre 30 y 80.")
            valor = int(input(f"Ingrese un valor entero entre 30 y 80 para la posicion, (fila: {f+1}, columna: {c+1}): "))
        a.append(valor)
    matriz.append(a)

#imprima todos los datos de la matriz
for a in matriz:
    for elemento in a:
        print(f"{elemento:4}", end=' ')
    print()

#imprima solo los datos de la diagonal secundaria de arriba hacia abajo
print("Diagonal secundaria:")
for i in range(filas):
    print(f"{matriz[i][columnas - 1 - i]:4}", end=' ')
