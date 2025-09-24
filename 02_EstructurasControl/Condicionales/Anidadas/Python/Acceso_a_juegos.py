edad = int(input("Ingrese su edad: "))
estatura = int(input("Ingrese su estatura en cm: "))

if (edad>=12):
    print("Puedes entrar a la montaña Rusa")
    if (estatura <140):
        print("Pero debes ir acompañado de un adulto por tu estatura.")
else:
    print("Puedes entrar solo a juegos infantiles")
    