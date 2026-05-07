print("CalcularPorcentajeDeVaronesYMujeresQueHay")

varones=int(input("Ingrese la cantidad de varones: "))
mujeres=int(input("Ingrese la cantidad de mujeres: "))

total=varones+mujeres

porcentajeVarones=((varones/total)*100)
porcentajeMujeres=((mujeres/total)*100)

print(f"\nEl porcentaje de varones es: {porcentajeVarones:.2f}%")
print(f"\nEl porcentaje de mujeres es: {porcentajeMujeres:.2f}%")