from Lista import Lista
#Creación del programa
lista = Lista()
#Agregado de datos
lista.agregar("1")
lista.agregar("2")
lista.agregar("3")
lista.agregar("4")
lista.agregar("5")
lista.agregar("6")
lista.agregar("7")
lista.agregar("8")
lista.agregar("9")
lista.agregar("10")

print("Lista original: ")
lista.imprimir()
print("Lista ordenada: ")
lista.ordenar()
lista.imprimir()
print("Lista desordenada: ")
lista.desordenar()
lista.imprimir()
print("SE ELIMINA EL NÚMERO '1'")
lista.eliminar("1")

print("SE BUSCA EL NÚMERO '7'")
if lista.buscar("7"):
    print("****************************")
    print("El número esta en la lista")
    print("****************************")
else:
    print("El número NO esta en la lista")
lista.imprimir()

print("Número '8' insertado en la posicion 2")
lista.insertar(2,"8")
lista.imprimir()
print("Lista recorrido inicio a fin: ")
lista.recorridoInicioFin()
print("Lista recorrido fin a inicio: ")
lista.recorridoFinInicio()