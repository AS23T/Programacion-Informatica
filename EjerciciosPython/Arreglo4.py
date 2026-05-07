#Dado 1 arreglo con los numeros del 1 al 10 genere las tablas de multiplicar
#y las imprima como tabla con sus resultados

Arreglo = [i for i in range(0, 11)]

print("Tabla de multiplicar del 1 al 10:")
for i in Arreglo:
    print(f"\nTabla del {i}:")
    for j in Arreglo:
        print(f"{i} x {j} = {i * j}")
