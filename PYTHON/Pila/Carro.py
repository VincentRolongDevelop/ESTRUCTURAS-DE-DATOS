#Nombre de la clase
class Carro :
    #Atributos
    marca = ""
    placa = ""
    #Métodos
    def __init__(self, marca, placa) :
        self.marca = marca
       
        self.placa = placa

    def getMarca(self):
        return self.marca
        
    def getPlaca(self):
        return self.placa

    def toString(self):
        return "\nMarca: " + self.marca + "\nPlaca: " + self.placa
