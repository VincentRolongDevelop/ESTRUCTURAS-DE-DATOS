from Pila import Pila
from Carro import Carro

pila = Pila()

control = True
#Inicio del programa
while control:
    opc = 0
    print("******MENU*******")
    print("1. Agregar dato")
    print("2. Buscar dato")
    print("3. Ordenar datos")
    print("4. Desordenar datos")
    print("5. Eliminar dato")
    print("6. Insertar dato")
    print("7. Recorrer IMPRIMIR de INICIO A FIN")
    print("8. Recorrer IMPRIMIR de FIN A INICIO")
    print("9. Imprimir colección de pila")
    print("10. Salir")
    print("******MENU*******")
    
    try:
        opc = int(input("Ingrese una opcion: "))
    except ValueError:
        print("************")
        print("Opcion no valida invalida")
        print("******ERROR*******")
       

    if opc == 1:
        print("**********OPCIÓN AGREGAR**********")
        marca = input("Ingrese el marca del carro: ")
        placa = input("Ingrese la placa del carro: ")
        
        nuevoCarro = Carro(marca, placa.upper())
        pila.agregar(nuevoCarro)
        print("CARRO AGREGADO")
        

    elif opc == 2:
        print("**********OPCIÓN BUSCAR**********")
        placa = input("Ingrese la placa del carro a buscar: ")
        busqueda = pila.buscar(placa)

        if busqueda == None:
            print("NO SE HA INGRESADO NINGUNA PLACA")
        
        else:
            print("El Carro de placa "+busqueda.getPlaca()+" "+busqueda.getMarca())
           
        
    elif opc == 3:
        print("**********OPCIÓN ORDENAR**********")
        pila.ordenar()
        print("PILA ORDENADA CON BASE A PLACA DE MENOR A MAYOR")
       

    elif opc == 4:
        print("**********OPCIÓN DESORDENAR**********")
        pila.desordenar()
        print("PILA DESORDENADA")
       

    elif opc == 5:
        print("**********OPCIÓN ELIMINAR**********")
        placa = input("Ingrese la placa del carro que se debe eliminar: ")
        if(placa == None):
            print("NO HA INGRESADO NINGUNA PLACA PARA ELIMINAR")
        else:
            elimina = pila.eliminar(placa)
            if elimina == -1:
                print("NO EXISTE EL CARRO CON ESA PLACA")
            else:
                print("EL CARRO DE PLACA "+placa+" FUE SIDO ELIMINADO")
               
    elif opc == 6:
        print("**********OPCIÓN INSERTAR**********")
        marca = input("Ingrese la marca del carro: ")
        placa = input("Ingrese la placa del carro: ")
        posicion = int(input("Ingrese la posición donde desea insertar el carro: "))

        nuevoCarro = Carro(marca,  placa.upper())
        
        if(posicion >= 0 and posicion <= pila.size):
            pila.insertar(posicion, nuevoCarro)
            print("EL CARRO FUE INSERTADO EN LA POSICION ",posicion)
            input("PRESIONE UNA TECLA PARA ENTER/INTRO PARA IR AL MENU...")
            print("**********INSERTAR**********")
        else:
            print("*************")
            print("Posición dada invalida")
            print("*************")
                
    elif opc == 7:
        print("**********OPCIÓN DE RECORRER DE INICIO A FIN**********")
        pila.recorrerDeInicioAFin()
        
    elif opc == 8:
        print("**********OPCION DE RECORRER DE FIN A INICIO**********")
        pila.recorrerDeFinAInicio()
        

    elif opc == 9:
        print("**********OPCIÓN IMPRIMIR**********")
        pila.imprimir()
        print("**********IMPRIMIR**********")
        

    elif opc == 10:
        control = False