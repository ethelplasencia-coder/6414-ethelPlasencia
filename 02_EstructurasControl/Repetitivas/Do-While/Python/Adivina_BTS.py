palabra = ""

print("Escribe un número del 1 a 7 o SALIR, y adivina el personaje de BTS")

while True:
    palabra = input("\nTu número es: ")

    if palabra == "1":
        respuesta = input("Es el menor del grupo. ¿Quién es? ")
        if respuesta == "Jungkook":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra == "2":
        respuesta = input("Es el mayor del grupo. ¿Quién es? ")
        if respuesta == "Jin":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra == "3":
        respuesta = input("Es el líder del grupo. ¿Quién es? ")
        if respuesta == "RM":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra == "4":
        respuesta = input("Es el más dormilón del grupo. ¿Quién es? ")
        if respuesta == "Suga":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra == "5":
        respuesta = input("Tiene personalidad amistosa, carismática y alegre. ¿Quién es? ")
        if respuesta == "V":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra == "6":
        respuesta = input('Es conocido como "La luz del sol". ¿Quién es? ')
        if respuesta == "Jhope":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra == "7":
        respuesta = input("Es el más pequeño del grupo. ¿Quién es? ")
        if respuesta == "Jimin":
            print("¡ADIVINASTE!")
            break
        else:
            print("¡NO ADIVINASTE!")

    elif palabra.upper() == "SALIR":
        break

print("¡Puerta abierta!")
