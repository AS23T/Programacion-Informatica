import random  # Importamos el módulo random para generar números aleatorios
# Creamos una lista vacía para almacenar las 30 notas ingresadas por el usuario
A = []
# Usamos un ciclo for para pedir 30 notas, una por una
for i in range(30):
    # Mostramos un mensaje personalizado con el número de la nota (i+1 porque los índices parten de 0)
    nota = float(input(f"Ingrese Nota n°{i+1}: "))
    # Agregamos la nota ingresada a la lista A
    A.append(nota)
# Generamos el arreglo B con 30 números decimales aleatorios entre 1.0 y 7.0
# Se redondea cada número a 2 decimales usando round()
B = [round(random.uniform(1.0, 7.0), 2) for _ in range(30)]
# Calculamos el promedio de cada par de notas de A y B y los guardamos en C
# También se redondea cada promedio a 2 decimales
C = [round((A[i] + B[i])/2, 2) for i in range(30)]
# Imprimimos el contenido de los arreglos A, B y C en forma horizontal
print("\nArreglo A:")
# Se imprime cada número con 2 decimales, separados por |
print(" | ".join([f"{n:.2f}" for n in A]))
print("\nArreglo B:")
print(" | ".join([f"{n:.2f}" for n in B]))
print("\nArreglo C (promedio de A y B):")
print(" | ".join([f"{n:.2f}" for n in C]))