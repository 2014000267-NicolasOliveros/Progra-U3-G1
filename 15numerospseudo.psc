Algoritmo Lecc16_Act2_Inci3

    Definir numeros Como Entero
    Dimension numeros[15]

    Definir i, j Como Entero
    Definir repetido Como Logico

    repetido <- Falso

    Para i <- 0 Hasta 14 Hacer
        Escribir "Ingrese el número ", i + 1, ": "
        Leer numeros[i]
    FinPara

    Para i <- 0 Hasta 13 Hacer
        Para j <- i + 1 Hasta 14 Hacer
            Si numeros[i] = numeros[j] Entonces
                repetido <- Verdadero
            FinSi
        FinPara
    FinPara

    Si repetido Entonces
        Escribir "Sí hay números repetidos en el arreglo."
    Sino
        Escribir "No hay números repetidos en el arreglo."
    FinSi

FinAlgoritmo
