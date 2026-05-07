#Genere los 15 multiplos de 16 que hay desde 160, guardar los multiplos en un arreglo

Arreglo =[160 + 16 * i for i in range(15)]

print("Los 15 multiplos de 16 que hay desde 160 son:")

print(" | ".join([f"{n}" for n in Arreglo]))