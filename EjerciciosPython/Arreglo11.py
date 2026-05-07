#en arreglo C que lea varios numeros, y que los guarde en un arreglo,
#solo si los elementos son multiplos de 3. Imprimir el arreglo final.

C = []
while True:
    try:
        num = float(input("Ingrese un numero ('fin' o cualquier palabra para terminar): "))
        if num % 5 == 0 or num == 1:
            C.append(num)
    except ValueError:
        if input("¿Confirmar? (s/n): ").lower() == 's':
            break
        else:
            continue
if not C:
    print("No se ingresaron numeros multiplos de 5.")
else:
    print("Arreglo final con numeros multiplos de 5:")
    print(" | ".join([f"{n}" for n in C]))