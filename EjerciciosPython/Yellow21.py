A=[0,0,0]
B=[0,0,0]
C=[0,0,0]
# Este programa toma tres números enteros de dos listas, los suma e imprime los resultados.
for i in range(0,3):
    A.append(int(input(f"Ingrese el dato 1.{i+1}: ")))
for i in range(0,3):
    B.append(int(input(f"Ingrese el dato 2.{i+1}: ")))
    C[i]= A[i] + B[i]
for i in range(0,3):
    print(C[i])