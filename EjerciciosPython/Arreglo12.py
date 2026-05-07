#en variable C que lea numeros y los guarde en un arreglo A,
#ordenar los numeros de menor a mayor y guardarlos ordenados en un arreglo B,
#imprimir ambos arreglos

A = []
while True:
    try:
        C = float(input("Ingrese un numero ('fin' o cualquier palabra para terminar): "))
        A.append(C)
    except ValueError:
        if input("¿Confirmar? (s/n): ").lower() == 's':
            break
        else:
            continue
if not A:
    print("No se ingresaron numeros.")
else:
    B = sorted(A)
    
    print("Arreglo A (original):")
    print(" | ".join([f"{n}" for n in A]))
    
    print("Arreglo B (ordenado de menor a mayor):")
    print(" | ".join([f"{n}" for n in B]))
