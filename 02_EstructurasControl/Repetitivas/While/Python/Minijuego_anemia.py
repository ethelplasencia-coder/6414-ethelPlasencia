puntos = 0
opcion = ""

while opcion != "3":
    print("\n=== MENU DEL JUEGO ===")
    print("1. Preguntas")
    print("2. Completar palabras")
    print("3. Resultados y salir")
    opcion = input("Elige una opción: ")

    if opcion == "1":
        print("\n--- PREGUNTAS ---")
        print("1) ¿Qué nutriente falta comúnmente en la anemia?")
        print("1. Calcio")
        print("2. Hierro")
        print("3. Sodio")
        respuesta = input("Elige la opción correcta: ")

        if respuesta == "2":
            print("¡Correcto!")
            puntos += 1
        else:
            print("Incorrecto")

    elif opcion == "2":
        print("\n--- COMPLETAR PALABRAS ---")
        print("A_EMI_")
        print("Elige la opción correcta:")
        print("1. A-O")
        print("2. N-A")
        print("3. D-M")
        respuesta = input("Tu respuesta: ")

        if respuesta == "2":
            print("¡Correcto!")
            puntos += 1
        else:
            print("Incorrecto")

    elif opcion == "3":
        print("\n--- RESULTADOS ---")
        print(f"Tu puntaje total es: {puntos}")
        print("¡Gracias por jugar!")

    else:
        print("Opción no válida. Intenta nuevamente.")
