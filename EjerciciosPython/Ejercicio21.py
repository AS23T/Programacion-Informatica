print("LeyDelMenorEsfuerzo")

# float = decimal
total = 12
porcMini = 0.70

import math
asistMini = math.ceil(total * porcMini)

faltPerm = total - asistMini

print(f"\nEl alumno puede faltar como maximo a {faltPerm} clases sin reprobar por inasistencia, {asistMini} de asistencia minima")