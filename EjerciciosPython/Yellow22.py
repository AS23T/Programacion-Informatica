import tkinter as tk
import random

def girar_ruleta():
    numeros = [random.randint(0, 9) for _ in range(3)]
    resultado.set(f"{numeros[0]}  {numeros[1]}  {numeros[2]}")
    if numeros[0] == numeros[1] == numeros[2]:
        mensaje.set("¡Ganaste! 777")
    else:
        mensaje.set("Intenta de nuevo")

root = tk.Tk()
root.title("Máquina 777")

resultado = tk.StringVar()
mensaje = tk.StringVar()

tk.Label(root, text="Máquina 777", font=("Arial", 20)).pack(pady=10)
tk.Label(root, textvariable=resultado, font=("Arial", 30)).pack(pady=10)
tk.Button(root, text="Girar", command=girar_ruleta, font=("Arial", 16)).pack(pady=10)
tk.Label(root, textvariable=mensaje, font=("Arial", 16)).pack(pady=10)

root.mainloop()