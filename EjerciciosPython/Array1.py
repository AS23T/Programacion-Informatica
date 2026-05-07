A = [0] * 1000

numeroactual = 1

for i in range(1000):
    A[i] = numeroactual
    numeroactual += 1

print("El valor de A es", A[999])
print("El valor de A es", A[0])
print("El valor de A es", A[500])
print("El valor de A es", A[999] + A[0] + A[500])
print("El valor de A es", A[999] * A[0] * A[500])
print("El valor de A es", A[999] - A[0] - A[500])
print("El valor de A es", A[999] / A[0] / A[500])
print("El valor de A es", A[999] % A[0] % A[500])
print("El valor de A es", A[999] ** A[0] ** A[500])
print("El valor de A es", A[999] // A[0] // A[500])
print("El valor de A es", A[999] + A[0] - A[500])
print("El valor de A es", A[999] * A[0] - A[500])
print("El valor de A es", A[999] - A[0] + A[500])
print("El valor de A es", A[999] / A[0] + A[500])
print("El valor de A es", A[999] % A[0] + A[500])
print("El valor de A es", A[999] ** A[0] + A[500])
print("El valor de A es", A[999] // A[0] + A[500])
print("El valor de A es", A[999] + A[0] * A[500])
print("El valor de A es", A[999] - A[0] * A[500])
print("El valor de A es", A[999] * A[0] + A[500])
print("El valor de A es", A[999] / A[0] * A[500])
print("El valor de A es", A[999] % A[0] * A[500])