horas = float(input("Ingrese las horas de trabajo: "))

tarifa =float(input("Ingrese la tarifa por hora: "))

if (horas <=0):
    pago = horas * tarifa
else: 
    horasextras= horas - 40
    pago= int(40*tarifa)+(horasextras*tarifa*1.15)

print ("El pago es: ", pago)







