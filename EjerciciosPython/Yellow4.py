print("Calcula porcentajes\n")
h=int(input("Ingrese cantidad de hombres: "))
m=int(input("Ingrese cantidad de mujeres: "))
total= h + m
PorcHombre= h * 100/total
PorcMujeres= 100 - PorcHombre
print(f"El porcentaje de hombres es {PorcHombre:.2f}% y el de mujeres es {PorcMujeres}%")
