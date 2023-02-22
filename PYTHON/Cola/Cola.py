from Estudiante import Estudiante
#Nombre de lacola
class Cola :
    #Uso de cola
    cola = [Estudiante]
    tamanoCola = 0

    #Métodos
    def __init__(self):
        self.cola = [Estudiante]
        self.tamanoCola = 0

    def agregar(self, objeto):
        self.cola.append(objeto)
        self.tamanoCola += 1
        
    def buscar(self, codigoNumeroId) :
        for i in range(1, self.tamanoCola+1) :
            if self.cola[i].getgetcodigoId() == codigoNumeroId:
                return self.cola[i]

    def ordenar(self):
        for i in range(1, self.tamanoCola+1) :
            for j in range(i, self.tamanoCola+1) :
                if self.cola[i].getcodigoId() > self.cola[j].getcodigoId() :
                    ayu = self.cola[i]
                    self.cola[i] = self.cola[j]
                    self.cola[j] = ayu
        
    def desordenar(self) :
        for i in range(1, self.tamanoCola+1) :
            for j in range(i, self.tamanoCola+1) :
                if self.cola[i].getcodigoId() < self.cola[j].getcodigoId() :
                    ayu = self.cola[i]
                    self.cola[i] = self.cola[j]
                    self.cola[j] = ayu
    
    #Metodo eleminar por numero de identificacion
    def eliminar(self, codigoNumeroId) :
        for i in range(1, self.tamanoCola+1) :
            if self.cola[i].getcodigoId() == codigoNumeroId :
                self.cola.pop(i)
                self.tamanoCola -= 1
                break

    def insertar(self, pos, e) :
        self.cola.insert(pos, e)
        self.tamanoCola += 1
    
    def recorrerDeinicoAfin(self) :
        for i in range(1, self.tamanoCola+1) :
            print(self.cola[i].toString())
            print("********************************")
    
    def recorrerDeFinaInicio(self) :
        for i in reversed(range(1, self.tamanoCola+1)) :
            print(i, self.cola[i].toString())
            print("********************************")

        
    def imprimir(self) :
        for i in range(1, self.tamanoCola+1) :
            print(self.cola[i].toString())
            print("********************************")