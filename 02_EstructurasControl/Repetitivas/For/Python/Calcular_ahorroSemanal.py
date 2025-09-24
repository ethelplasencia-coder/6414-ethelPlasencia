# Calcula el ahorro semanal

ahorro = 0.0
dinero = float(input("¿Cuánto ahorras por día? "))

for i in range(1, 8):  # de 1 a 7 (7 días)
    ahorro = ahorro + dinero

print("Tu ahorro total durante la semana es de:", ahorro)
