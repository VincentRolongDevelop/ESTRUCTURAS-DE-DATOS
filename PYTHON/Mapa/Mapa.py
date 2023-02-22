import collections

#Nombre de la clase
class Mapa :
    mapa = {}
    #Métodos de la clase
    def agregar(self, palabra, significado):
        self.mapa[palabra] = significado
    
    def buscar(self, palabra):
        return self.mapa[palabra]
    
    def ordenar(self):
        self.mapa = collections.OrderedDict(sorted(self.mapa.items()))
    
    def desordenar(self):
       self.mapa = collections.OrderedDict(sorted(self.mapa.items(), reverse=True))

    def eliminar(self, palabra):
        del self.mapa[palabra]

    def insertar(self, palabra, significado):
        self.mapa[palabra] = significado

    def recorridoDeInicioAFin(self):
        for key in self.mapa:
            print(key+': '+self.mapa[key])
    

    def recorridoDeFinAInicio(self):
        mapaDeFinAInicio = collections.OrderedDict(sorted(self.mapa.items()))
        for key in mapaDeFinAInicio:
            print(key+'---> '+mapaDeFinAInicio[key])

    def imprimir(self):
        print("*******SIGNIFICADOS DE PALABRAS EN IDIOMAS*********")
        for key in self.mapa:
            print(key+': '+self.mapa[key])
