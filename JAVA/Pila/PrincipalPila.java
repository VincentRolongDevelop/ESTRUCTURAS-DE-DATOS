package JAVA.Pila;

import java.util.InputMismatchException;
import java.util.Scanner;
//Clase main
public class PrincipalPila {

    //Método main
    public static void main(String[] args) {
        //Instancias
        Pila pila = new Pila();

        Scanner in = new Scanner(System.in);
        
        int opcion = 0;
        do {
            System.out.println("******MENU*******");
            System.out.println("1. Agregar dato");
            System.out.println("2. Buscar dato");
            System.out.println("3. Ordenar datos");
            System.out.println("4. Desordenar datos");
            System.out.println("5. Eliminar dato");
            System.out.println("6. Insertar dato");
            System.out.println("7. Recorrer coleccion de INICIO A FIN");
            System.out.println("8. Recorrer coleccion de FIN A INICIO");
            System.out.println("9. Imprimir colección de pila");
            System.out.println("10. Salir");
            System.out.println("******************");

            try{
                System.out.print(":");
                opcion = in.nextInt();
            }catch(InputMismatchException e){
                System.out.println("posicion invalida para el menu");
                in = new Scanner(System.in);
            }
            
            //Inicio de validación switch
            switch (opcion) {
                case 1:
                    System.out.println("**********OPCIÓN AGREGAR**********");
                    System.out.print("Ingrese el marca del carro: ");
                    String marca = in.next();
                                     
                    System.out.print("Ingrese la placa del carro: ");
                    String placa = in.next();

                    Carro nuevo = new Carro(marca, placa.toUpperCase());
                    pila.agregar(nuevo);
                    System.out.println("**********OPCIÓN AGREGAR**********");
                    break;

                case 2:
                    System.out.println("**********OPCIÓN BUSCAR**********");
                    System.out.print("Ingrese la placa del carro: ");
                    String busq = in.next();
                    int indice = pila.buscarPorPlaca(busq);
                    if (indice != -1){
                        System.out.println("El carro se encuentra en la posición ["+indice+"]");
                        pila.imprimir(indice);
                    }else{
                        System.out.println("El carro no se encuentra en la pila");
                    }
                    System.out.println("**********OPCIÓN BUSCAR**********");
                    break;

                case 3:
                    System.out.println("**********OPCIÓN ORDENAR**********");
                    pila.ordenar();
                    System.out.println("PILA ORDENADA CON BASE EN LA PLACA");
                    System.out.println("**********OPCIÓN ORDENAR**********");
                    break;
                
                case 4:
                    System.out.println("**********OPCIÓN DESORDENAR**********");
                    pila.desordenar();
                    System.out.println("PILA DESORDENADA CON BASE EN LA PLACA");
                    System.out.println("**********OPCIÓN DESORDENAR**********");
                    break;
                
                case 5:
                    System.out.println("**********OPCIÓN ELIMINAR**********");
                    System.out.print("Ingrese la placa del carro a eliminar: ");
                    String eliminar = in.next();
                    pila.eliminar(eliminar.toUpperCase());
                    System.out.println("**********OPCIÓN ELIMINAR**********");
                    break;

                case 6:
                    System.out.println("**********OPCIÓN INSERTAR**********");
                    
                    System.out.print("Ingrese el marca del carro: ");
                    String marcaIn = in.next();
                   
                    System.out.print("Ingrese la placa del carro: ");
                    String placaIn = in.next();

                    Carro nuevoIn = new Carro(marcaIn,  placaIn.toUpperCase());
                    System.out.print("Ingrese la posición donde desea insertar el carro ingresado: ");
                    int pos = in.nextInt();
                    pila.insertar(pos, nuevoIn);
                    System.out.println("**********OPCIÓN INSERTAR**********");
                    break;

                case 7:
                    System.out.println("**********OPCIÓN RECORRER DE INICIO A FIN**********");
                    pila.recorrerDeinicioAFin();
                    System.out.println("**********OPCIÓN RECORRER DE INICIO A FIN**********");
                    break;

                case 8:
                    System.out.println("**********RECORRER DE FIN A INICIO**********");
                    pila.recorrerDeFinAInicio();
                    System.out.println("**********RECORRER DE FIN A INICIO**********");
                    break;

                case 9:
                    System.out.println("**********OPCIÓN IMPRIMIR**********");
                    pila.imprimir();
                    System.out.println("**********OPCIÓN IMPRIMIR**********");
                    break;
                default:
                    break;
            }
        } while (opcion != 10);

        in.close();
    }
}