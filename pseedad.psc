Algoritmo Lecc16_Act2_Inci1

    Escribir "DATOS ACADÉMICOS"
    Escribir "Nicolás Oliveros"
    Escribir "4to Bachillerato en CCLL con orientación en Computación"
    Escribir "Sección C"
    Escribir "Clave 26"

    Definir edadpersonas Como Entero[7]
    Definir cantpermay Como Entero
    Definir cantpermen Como Entero
    Definir i Como Entero

    cantpermay <- 0
    cantpermen <- 0

    Para i <- 0 Hasta 6 Hacer

        Escribir ""
        Escribir "Ingrese la edad de la persona ", i + 1, ": "
        Leer edadpersonas[i]

        Si edadpersonas[i] >= 18 Entonces
            cantpermay <- cantpermay + 1
        Sino
            cantpermen <- cantpermen + 1
        FinSi

    FinPara

    Escribir ""
    Escribir "Cantidad de Personas Mayores de edad: ", cantpermay
    Escribir "Cantidad de Personas Menores: ", cantpermen

FinAlgoritmo
