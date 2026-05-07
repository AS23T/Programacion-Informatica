print("CalcularLaVelocidadDeUnAtletaEnKM/HR")

minu = int(input("Ingrese la velocidad en minutos: "))
seg = int(input("Ingrese la velocidad en segundos: "))
cent = int(input("Ingrese la centesimas de segundos: "))
distM = int(input("Ingrese la distancia en metros: "))

tiempoSeg = (minu * 60) + seg + (cent / 100)
tiempoHrs = tiempoSeg / 3600

distKM = distM / 1000

if tiempoHrs >0:
    velocidad = distKM / tiempoHrs
    print(f"\nVelocidad promedio: {velocidad:.2f} km/h")
else:
    print("Error: El valor debe ser mayor a 0")