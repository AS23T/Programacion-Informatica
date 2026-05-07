#Un arreglo de tamaño 10 de solo los multiplos de 7 que hay desde 700, imprimir el arreglo

arreglo = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

for i in range(10):
    m = 700 + i * 7
    arreglo[i] = int(m)

print("arreglo de los primeros 10 multiplos de 7 a partir de 700:")
print(",".join([f"{n}" for n in arreglo]))