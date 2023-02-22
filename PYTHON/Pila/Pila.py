from Carro import Carro
#Nombre de la clase
class Pila:
    pila = [Carro]
    tamano = 0

    #Métodos
    def agregar(self, carro):
        self.pila.append(carro)
        self.tamano += 1
    #Método buscar
    def buscar(self, placa):
        for i in range(1, self.tamano+1) :
            if self.pila[i].getPlaca() == placa :
                return self.pila[i]
    #Método Ordenar
    def ordenar(self):
        for i in range(1, self.tamano+1) :
            for j in range(1, self.tamano+1) :
                if self.pila[j].getPlaca() > self.pila[i].getPlaca() :
                    auxiliar = self.pila[i]
                    self.pila[i] = self.pila[j]
                    self.pila[j] = auxiliar
    #Método desordenar
    def desordenar(self):
        for i in range(1, self.tamano+1) :
            for j in range(1, self.tamano+1) :
                if self.pila[j].getPlaca() < self.pila[i].getPlaca() :
                    auxiliar = self.pila[i]
                    self.pila[i] = self.pila[j]
                    self.pila[j] = auxiliar
    #Método eliminar
    def eliminar(self, placa):
        result = 0
        for i in range(1, self.tamano+1) :
            if self.pila[i].getPlaca() == placa :
                self.pila.pop(i)
                self.tamano -= 1
                result = 1
                break
            else :
                result = -1
        return result
    #Método insertar
    def insertar(self, pos, carro):
        self.pila.insert(pos, carro)
        self.tamano += 1
        return 0
    #Método recorrer de inicio a fin
    def recorrerDeInicioAFin(self):
        for i in range(1, self.tamano+1) :
            print(i, self.pila[i].toString())
    #Método recorrer de fin a inicio
    def recorrerDeFinAInicio(self):
        for i in reversed(range(1, self.tamano+1)) :
            print(i, self.pila[i].toString())
    #Método imprimir
    def imprimir(self):
        for i in range(1, self.tamano+1) :
            print(i, self.pila[i].toString())