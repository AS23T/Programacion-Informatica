#en arreglo C que lea varios numeros, los guarde como arreglo, busque los elementos pares
#y los cambie por unos (1), luego imprima el arreglo modificado.

C = []

while True:
    try:
        C.append(float(input("Ingrese un numero ('fin' o cualquier palabra para terminar): ")))
    except ValueError:
        if input("¿Confirmar? (s/n): ").lower() == 's':
            break
        else:
            continue
if not C:
    print("No se ingresaron numeros.")
else:
    C = [1 if x % 2 == 0 else x for x in C]

    print("Arreglo modificado:")
    print(" | ".join([f"{n}" for n in C]))
