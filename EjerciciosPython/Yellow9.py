a = int(input("Ingrese valor de a: "))

for i in range(1, 20):
    if i * a == 5:
        print(a * i)
    elif i * a == 10:
        print(a * i)
    else:
        print("Error")
