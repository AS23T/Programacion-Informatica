#en un curso, el profesor necesita entregar las estadisticas de crecimiento de sus alumnos, para eso le solicita a usted, que realice un programa en python

#que ingrese las estaturas de cada alumno en un arreglo E de tamaño 35
E = []

for i in range(35):
    valor = float(input(f"Ingrese la estatura del alumno {i+1}: "))
    E.append(valor)

#sume todas las estaturas
suma = sum(E)

#calcule el promedio
promedio = suma/len(E)

#encuentre la estatura mas alta y la mas baja
estaturaMasAlta = max(E)
estaturaMasBaja = min(E)

#imprima el arreglo de las estaturas
print(" | ".join(f"{estatura:.2f}" for estatura in E))

#imprima la suma, el promedio, la mayor y la menor
print(f"Suma de estaturas: {suma}")
print(f"Promedio de estaturas: {promedio}")
print(f"Estatura mas alta: {estaturaMasAlta}")
print(f"Estatura mas baja: {estaturaMasBaja}")

