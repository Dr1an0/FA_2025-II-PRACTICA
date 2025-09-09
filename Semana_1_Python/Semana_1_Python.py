def ejer1():
    nombre = input("INGRESE SU NOMBREP: ")
    carrera = input("INGRESE SU CARRERA: ")

    print(f"\n{nombre}, BIENVENIDO A FUNDAMENTOS DE ALGORITMO DE {carrera}") #f = $ en C# (ES CONCATENAR)
def ejer2():
    print("\"\"James\"\"")

def ejer3():
    x = int(input("Ingresar el valor de x: "))
    y = int(input("Ingresar el valor de y: "))

    print("Suma: ", (x+y))
    print("Resta: ", (x-y))
    print("Multiplicación: ", (x*y))
    print("División: ", (x/y))

import math #importando la libreria math

def ejer4():
    num = float(input("Ingrese un número decimal: "))

    print("Raiz2: ", math.sqrt(num))
    print("Redondeado: ", round(num,0))
    print("Al cubo: ", math.pow(num,3))
    print("Raiz3: ", num ** (1/3))

def ejer5():
    num = input("Ingrese número: ")

    entero = int(num)
    deci = float(num)

    print("Resto: ", (entero%2))
    print("División: ", (deci/3))

ejer5()