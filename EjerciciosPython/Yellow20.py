arreglo1 = [1, 2, 3, 4, 5]
arreglo2 = [1, 2, 3, 4, 5]

arreglo3 = [a + b for a, b in zip(arreglo1, arreglo2)]

print(arreglo3)