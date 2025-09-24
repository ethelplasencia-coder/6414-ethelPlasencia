planeta = int(input("Ingrese el número del planeta (1 al 8): "))

if planeta == 1:
    print("Mercurio → El más cercano al Sol.")
elif planeta == 2:
    print("Venus → El planeta más caliente.")
elif planeta == 3:
    print("Tierra → ¡Nuestro hogar!")
elif planeta == 4:
    print("Marte → Conocido como el planeta rojo.")
elif planeta == 5:
    print("Júpiter → El más grande del sistema solar.")
elif planeta == 6:
    print("Saturno → Reconocido por sus anillos.")
elif planeta == 7:
    print("Urano → Gira de costado.")
elif planeta == 8:
    print("Neptuno → El más lejano al Sol.")
else:
    print("Número inválido, solo hay 8 planetas principales.")