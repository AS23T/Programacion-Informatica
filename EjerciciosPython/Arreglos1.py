#Que lea 10 elementos, los guarde en un arreglo, luego duplique los 
#elementos del arreglo (que queden guardados) e imprima los elementos duplicados

Arreglo = []

for i in range(10):
    Arreglo.append(float(input(f"Ingrese el dato como N° Entero, vamos en {i+1}: ")))
    
ArregloDuplicado = [2 * Arreglo[i] for i in range(10)]

print("\nArreglo:")
print(" | ".join([f"{n}" for n in Arreglo]))

print("\nArreglo Duplicado, los elementos duplicados de Arreglo:")
print(" | ".join([f"{n}" for n in ArregloDuplicado]))
