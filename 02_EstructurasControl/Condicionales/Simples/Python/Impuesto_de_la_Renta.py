# === Cálculo de Impuesto a la Renta ===

# Solicitar monto de la renta
renta = float(input("Ingrese el monto de su renta en soles: "))

# Condicional simple
if renta > 4000:
    impuesto = renta * 0.05
    print("El impuesto a pagar es: S/", impuesto)
