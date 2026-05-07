r='s'
while r=='s':
    m=int(input("Ingrese: "))
    if m<1 or m>7:
        print("No es nota")
    else:
        print("Es nota")
    r=input("Repetir?:")