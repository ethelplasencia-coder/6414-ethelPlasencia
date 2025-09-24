edad = int(input("Ingrese su edad: "))

if (edad < 14):
    print("Puede ver peliculas de comedia, romantica y ciencia ficciòn")
    if (edad < 6):
        print("Pero con el acompañamiento de un adulto")
else:
    print("Puede ver peliculas de terror, acciòn y entre otras")