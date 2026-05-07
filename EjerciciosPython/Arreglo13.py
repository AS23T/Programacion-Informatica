#en arreglo C que lea varios numeros y los guarde en un arreglo A,
#ordenar el arreglo de mayor a menor e imprimir (solo se debe usar 1 arreglo).

A = []

while True:
    entrada = input('Ingrese el/los numeros (o presiona "n" para terminar): ')
    if entrada.lower() == 'n':
        break
    try:
        n = float(entrada)
        A.append(n)
    except ValueError:
        print("Entrada invalida. Intente de nuevo.")
        
for i in range(len(A)):
    for j in range(i + 1, len(A)):
        if A[i] < A[j]:
            A[i], A[j] = A[j], A[i]
            
print("\nArreglo A ordenado de mayor a menor:")
print(" | ".join([f"{n:.2f}" for n in A]))