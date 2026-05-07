#for dentro de un for
for i in range(1, 10):
    for j in range(1, 10):
        print(f"{i} * {j} = {i * j}")
    print()

for i in range(10):
    for a in range(1):
        print("{i}*{a} igual {a}*{i}")
    print()


filas = 6
columnas = 3

matriz = []

for f in range(filas):
    fill = []
    for c in range(columnas):
        fill.append(0)
    matriz.append(fill)

for fill in matriz:
    for elemento in fill:
        print(elemento, end=' ')
    print()
