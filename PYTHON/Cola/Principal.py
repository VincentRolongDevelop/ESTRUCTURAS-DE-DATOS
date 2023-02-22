from Cola import Cola
from Estudiante import Estudiante

cola = Cola()
control = True

while control:
    opc = 0
    print("*************")
    print("1. Agregar dato")
    print("2. Buscar dato")
    print("3. Ordenar datos")
    print("4. Desordenar datos")
    print("5. Eliminar dato")
    print("6. Insertar dato")
    print("7. Recorrer IMPRIMIR de INICIO A FIN")
    print("8. Recorrer IMPRIMIR de FIN A INICIO")
    print("9. Imprimir colección de datos")
    print("10. Salir")
    print("*************")
    
    try:
        opc = int(input("Ingrese una para elegir opcion: "))
    except ValueError:
        print("*************")
        print("Opcion no valida")
        print("*************")
     
    if opc == 1:
        print("**********OPCIÓN AGREGAR**********")
        nombres = input("Ingrese el nombre del Estudiante: ")
        codigoId = int(input("Ingrese el numero de Id del Estudiante: "))
        

        nuevo = Estudiante(nombres,  codigoId)
        cola.agregar(nuevo)
        print("ESTUDIANTE AGREGADO")
        print("********************")

    elif opc == 2:
        print("**********OPCIÓN BUSCAR**********")
        codigoId = int(input("Ingrese el numero de identificacion del estudiante que desea buscar: "))

        if codigoId == None:
            print("NO HA INGRESADO NINGUNA ID")
        
        else:
            busqueda = cola.buscar(codigoId)
            if busqueda == None:
                print("NO HAY UN ESTUDIANTE CON ESA ID")
            else:
                print("El Estudiante de numero de ID "+str(codigoId)+" "+busqueda.getNombres()+" está en la cola")
           
        
    elif opc == 3:
        print("**********OPCIÓN ORDENAR**********")
        cola.ordenar()
        print("COLA ORDENADA POR ID DE MENOR A MAYOR")
        
    elif opc == 4:
        print("**********OPCIÓN DESORDENAR**********")
        cola.desordenar()
        
    elif opc == 5:
        print("**********OPCIÓN ELIMINAR**********")
        codigoId = int(input("Ingrese el ID del Estudiante a eliminar: "))
       
        if codigoId == None:
            print("NO HA INGRESADO NINGUNA UNA ID")
        
        else:
            busqueda = cola.buscar(codigoId)
            if busqueda == None:
                print("NO HAY UN ESTUDIANTE CON ESA ID")
            else:
                cola.eliminar(codigoId)
                print("EL ESTUDIANTE DE ID "+str(codigoId)+" "+busqueda.getNombres()+" FUE ELIMINADO")
       
    elif opc == 6:
        print("**********OPCIÓN INSERTAR**********")
        nombres = input("Ingrese el nombre del estudiante: ")
        codigoId = int(input("Ingrese el id del Estudiante: "))
        posicion = int(input("Ingrese la posicionición para insertar el Estudiante: "))

        nuevo = Estudiante(nombres, codigoId)
        
        if(posicion > 0 and posicion <= cola.size):
            cola.insertar(posicion, nuevo)
            print("ESTUDIANTE INSERTADO EN EL INDICE ",posicion)
        elif(posicion == 0):
            print("LA COLECCION COMIENZA EN 1")
        else:
            print("esta poscición no es valida")
                
    elif opc == 7:
        print("**********OPCIÓN RECORRER DE INICIO A FIN**********")
        cola.recorrerDeinicoAfin()
      

    elif opc == 8:
        print("**********OPCIÓN RECORRER DE FIN A INICIO**********")
        cola.recorrerDeFinaInicio()
        

    elif opc == 9:
        print("**********OPCIÓN IMPRIMIR**********")
        cola.imprimir()
       
        print("**********************************")

    elif opc == 10:
        control = False