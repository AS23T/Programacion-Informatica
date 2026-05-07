print("ExpresarLaCapacidadDeUnDiscoDuroEnMegaBite,KilobytesYBytes(ConociendoLaCapacidadDelDiscoEnGigabytes")

GB = float(input("Ingrese la capacidad del disco en Gigabytes: "))

MB = GB * 1024
KB = MB * 1024
Bytes = KB * 1024

print(f"La capacidad del disco es de: " + str(GB) + "GB, " + str(MB) + "MB, " + str(KB) + "KB y " + str(Bytes) + "Bytes")