a=0
b=0
c=0

while True:
    a=float(input("Ingrese el valor de a: "))
    if a<0:
        print("El valor de a debe ser mayor a 0")
        continue
    else:
        print("El valor de a es correcto es mayor a 0\n", a)
        break
