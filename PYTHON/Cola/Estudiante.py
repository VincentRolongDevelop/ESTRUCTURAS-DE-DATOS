
#Nombre de la clase
class Estudiante :
    #Métodos
    def __init__(self, nombres, codigoId):
        self.nombres = nombres
        self.codigoId = codigoId
            
    def getNombres(self):
        return self.nombres
           
    def getcodigoId(self):
        return self.codigoId
    
    def setNombres(self, nombres):
        self.nombres = nombres
        
    def setcodigoId(self, codigoId):
        self.codigoId = codigoId
        
    def toString(self):
        return "Nombres: " + self.nombres + "\nNúmero de codigo: "+ str(self.codigoId) 