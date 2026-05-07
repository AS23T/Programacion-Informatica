#en C que lea numeros desde teclado (el usuario debe determinar cuantos)
#que los guarde en un arreglo, luego pregunte al usuario un numero, multiplique
#los numeros iniciales por el ultimo numero ingresado y muestre los valores finales

C = []

while True:
    entrada = input("Ingresa un numero/s (o escribe 'fin' para terminar): ")
    if entrada.lower() == "fin":
        break
    try:
        C.append(float(entrada))
    except ValueError:
        print("Error. Por favor, ingresa un numero o 'fin'.")

if not C:
    print("No se ingresaron numeros.")
else:
    while True:
        try:
            mult = float(input("Ingresa el numero multiplicador: "))
            break
        except ValueError:
            print("Error. Por favor, ingresa un numero valido.")

    C = [lista * mult for lista in C]

    print("Lista final de numeros multiplicados:\n", C)
