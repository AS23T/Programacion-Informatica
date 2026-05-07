print("Cacular promedio")
Test1=float(input("Ingrese test1: "))
Test2=float(input("Ingrese test2: "))
Test3=float(input("Ingrese test3: "))
Certamen1=float(input("Ingrese certamen1: "))
Test4=float(input("Ingrese test4: "))
Certamen2=float(input("Ingrese certamen2: "))
NotaDePresentacion=(((Test1*0.5)+(Test2*0.5))*0.25)+(((Test3*0.3)+(Certamen1*0.7))*0.35)+(((Test4*0.3)+(Certamen2*0.7))*0.4)
print(f"La nota de presentacion es {round(NotaDePresentacion, 1)}\n") #redondea a 1
nex= float(input("Ingrese nota examen: "))
NotaFinal=NotaDePresentacion*0.6+nex*0.4
print(f"La nota final es {round(NotaFinal, 1)}") #redondea a 1