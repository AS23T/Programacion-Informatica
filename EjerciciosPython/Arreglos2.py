#Lea 10 numeros, los guarde en un arreglo, busque el menor y el mayor
#de los elementos y los imprima

Arreglo = []

for i in range(10):
    Arreglo.append(float(input(f"Ingrese el dato como N° Entero, vamos en {i+1}: ")))
    
Mayor = max(Arreglo)
Menor = min(Arreglo)

print("\nArreglo:")
print(" | ".join([f"{n}" for n in Arreglo]))

print(f"\nEl mayor elemento del arreglo es: {Mayor}")
print(f"El menor elemento del arreglo es: {Menor}")
