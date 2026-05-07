print("CalcularAreaYPerimetroDeUnRectangulo")

altura = float(input("Ingrese la altura del rectangulo: "))
while altura < 0:
    print("La altura debe ser mayor a 0")
    altura = float(input("Ingrese la altura del rectangulo: "))

base = float(input("Ingrese la base del rectangulo: "))
while base < 0:
    print("La base debe ser mayor a 0")
    base = float(input("Ingrese la base del rectangulo: "))

area= altura * base

perimetro= 2*(altura + base)

print(f"El área del rectángulo es: {area:.2f}, y el perímetro es: {perimetro:.2f}")