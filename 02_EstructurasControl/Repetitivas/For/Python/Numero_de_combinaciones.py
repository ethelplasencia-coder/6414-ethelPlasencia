# Calcula el número de combinaciones que se puede realizar con n° de polos y pantalones

polos = int(input("Ingresa el número de polos: "))
pantalones = int(input("Ingresa el número de pantalones: "))

combinaciones = 0

for i in range(1, polos + 1):        
    for j in range(1, pantalones + 1):   
        combinaciones += 1

print("Se puede realizar:", combinaciones, "combinaciones")
