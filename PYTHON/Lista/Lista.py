
class Lista:
    #Métodos de la clase lista
    def __init__(self):
        self.numerosEnteros = []

    def agregar(self,numero):
        self.numerosEnteros.append(numero)

    def buscar(self,numero):
        return self.numerosEnteros.index(numero)

    def ordenar(self):
        self.numerosEnteros.sort()

    def desordenar(self):
        self.numerosEnteros.sort(reverse=True)

    def eliminar(self,numero):
        self.numerosEnteros.remove(numero)

    def insertar(self,posicion,numero):
        self.numerosEnteros.insert(posicion,numero)

    def recorridoInicioFin(self):
        print(self.numerosEnteros)

    def recorridoFinInicio(self):
        print(self.numerosEnteros[::-1])

    def imprimir(self):
        print(self.numerosEnteros)
