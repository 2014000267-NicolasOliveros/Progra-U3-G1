Algoritmo Lecc16_Act2_Inci2

    Definir numeros Como Entero
    Dimension numeros[8]

    Definir i, mayor, posicion Como Entero

    Para i <- 0 Hasta 7 Hacer
        Escribir "Ingrese el número ", i + 1, ": "
        Leer numeros[i]
    FinPara

    mayor <- numeros[0]
    posicion <- 0

    Para i <- 1 Hasta 7 Hacer
        Si numeros[i] > mayor Entonces
            mayor <- numeros[i]
            posicion <- i
        FinSi
    FinPara

    Escribir "El número mayor es: ", mayor
    Escribir "Está en la posición: ", posicion + 1

FinAlgoritmo
