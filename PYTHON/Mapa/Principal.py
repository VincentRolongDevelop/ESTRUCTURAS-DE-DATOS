from Mapa import Mapa
#Creción del mapa
mapa = Mapa()
#Inicio de programa
mapa.agregar("amigo", "Que mantiene una relación de amistad con otra u otras personas.")
mapa.agregar("inteligencia", "Facultad de la mente que permite aprender, entender, razonar, tomar decisiones y formarse una idea determinada de la realidad.")
mapa.agregar("vejez", "Último período de la vida de una persona, que sigue a la madurez, y en el cual se tiene edad avanzada")
mapa.imprimir()

print("************************************************")
print("\nELIMINANDO LA PALABRA amigo\n")
print("************************************************")
datoEliminar = "amigo"
mapa.eliminar(datoEliminar )
mapa.imprimir()

print("************************************************")
print("*Buscando una palabra en el mapa*")
print("vejez")
print("************************************************")
datoABuscar = "vejez"
busqueda = mapa.buscar("vejez")
if busqueda != None:
    print("La palabra indicada como "+datoABuscar+" se encuentra en el mapa")
    print(datoABuscar+": "+busqueda)
else:
    print("La palabra indicada como "+datoABuscar+" no esta en el mapa")

print("************************************************")
print("*MAPA ORDENADO*")
print("************************************************")
mapa.ordenar()
mapa.imprimir()

print("************************************************")
print("*DESORDENANDO EL MAPA*")
print("************************************************")
mapa.desordenar()
mapa.imprimir()

print("************************************************")
print("*INSERTAR DATO A MAPA")
print("Se inserta = 'avion'")
print("----Su definición seria = 'Aeronave más pesada que el aire , provista de alas , cuya sustentación y avance son consecuencia de la acción de uno o varios motores '")
print("************************************************")
datoAInsertar = "avion"
significado = "Aeronave más pesada que el aire , provista de alas , cuya sustentación y avance son consecuencia de la acción de uno o varios motores '"
mapa.insertar(datoAInsertar, significado)
mapa.imprimir()

print("************************************************")
print("*RECORRIDO DE INICIO A FIN*")
print("************************************************")
mapa.recorridoDeInicioAFin()
print("************************************************")

print("************************************************")
print("*RECORRIDO DE FIN A INICIO*")
print("************************************************")
mapa.recorridoDeFinAInicio()
