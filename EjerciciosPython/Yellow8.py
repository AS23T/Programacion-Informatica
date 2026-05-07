a=0
b=0
c=0
d=0

while True:
    a=a+1
    b=b+1
    c = b*2 and a*3 or c+1
    float(input("Ingrese el valor de d: "))
    d=d+1
    if d>5:
        break
    else:
        print(c)