total = 0
opcion = ""

while opcion != "4":
    print("\n=== MENÚ ===")
    print("1. Almuerzos")
    print("2. Postres")
    print("3. Bebidas")
    print("4. Ver cuenta y salir")
    opcion = input("Elige una opción: ")

    if opcion == "1":
        print("\n--- Almuerzos ---")
        print("a. Pizza - s/.12.50")
        print("b. Hamburguesa - s/.10.00")
        print("c. Ensalada - s/.7.50")
        plato = input("Elige tu plato: ")

        if plato == "a":
            total += 12.50
            print("Has pedido Pizza")
        elif plato == "b":
            total += 10.00
            print("Has pedido Hamburguesa")
        elif plato == "c":
            total += 7.50
            print("Has pedido Ensalada")
        else:
            print("Opción no válida")

    elif opcion == "2":
        print("\n--- Postres ---")
        print("a. Helado - s/.5.00")
        print("b. Pastel - s/.6.50")
        print("c. Fruta - s/.4.00")
        postre = input("Elige tu postre: ")

        if postre == "a":
            total += 5.00
            print("Has pedido Helado")
        elif postre == "b":
            total += 6.50
            print("Has pedido Pastel")
        elif postre == "c":
            total += 4.00
            print("Has pedido Fruta")
        else:
            print("Opción no válida")

    elif opcion == "3":
        print("\n--- Bebidas ---")
        print("a. Agua - s/.2.00")
        print("b. Jugo - s/.3.50")
        print("c. Refresco - s/.2.50")
        bebida = input("Elige tu bebida: ")

        if bebida == "a":
            total += 2.00
            print("Has pedido Agua")
        elif bebida == "b":
            total += 3.50
            print("Has pedido Jugo")
        elif bebida == "c":
            total += 2.50
            print("Has pedido Refresco")
        else:
            print("Opción no válida")

    elif opcion == "4":
        print("\n--- Resumen de tu pedido ---")
        print(f"Total a pagar: s/. {total:.2f}")
        print("¡Gracias por tu visita!")

    else:
        print("Opción no válida. Intenta nuevamente.")
        
