package JAVA.Cola;
import java.util.InputMismatchException;
import java.util.Scanner;

//Nombre de la clase
public class PrincipalCola {

    //Método Main
    public static void main(String[] args) {
        //Instancia de la cola
        Cola cola = new Cola();
        //Uso de la clase Scanner
        Scanner in = new Scanner(System.in);

        int opcionUser = 0;
        //Inicio del programa con do-while
        do {
            System.out.println("******MENU ESTUDIANTE*******");
            System.out.println("1. Agregar dato");
            System.out.println("2. Buscar dato");
            System.out.println("3. Ordenar datos");
            System.out.println("4. Desordenar datos");
            System.out.println("5. Eliminar datos");
            System.out.println("6. Insertar datos");
            System.out.println("7. Recorrer coleccion de INICIO A FIN");
            System.out.println("8. Recorrer coleccion de FIN A INICIO");
            System.out.println("9. Imprimir colección");
            System.out.println("10. Salir");
            System.out.println("***************************");

            //Try-catch
            try {
                System.out.print(":");
                opcionUser = in.nextInt();
            } catch (InputMismatchException e) {
                System.out.println("");
                System.out.println("LA OPCION ES INVALIDAD");
                System.out.println("");
                in = new Scanner(System.in);
            }


           //Inicio del switch 
            switch (opcionUser) {
                case 1:
                    in = new Scanner(System.in);
                    System.out.println("**********OPCIÓN AGREGAR**********");
                    System.out.print("Ingrese el nombre del Estudiante: ");
                    String nombre = in.nextLine();

                    
                    
                    System.out.print("Ingrese el numero del codigo del Estudiante: ");
                    int numeroCodId = in.nextInt();

                

                    Estudiante nuevo = new Estudiante(nombre, numeroCodId);
                    cola.agregar(nuevo);
                    System.out.println("\nESTUDIANTE AGREGADO ");
                   
                    break;

                case 2:
                    System.out.println("**********OPCIÓN BUSCAR**********");
                    System.out.print("Ingrese el codigo de Identificacion del Estudiante: ");
                    int busqueda = in.nextInt();

                    Estudiante respuesta = cola.buscar(busqueda);
                    
                    if(respuesta != null){
                        System.out.println("El estudiante "+respuesta.getNombre()+" con codigo  "
                        +respuesta.getCodigoIdentificacion()+" esta en la cola");
                    }else{
                        System.out.println("El estudiante no esta en la cola");
                    }

                    
                    break;

                case 3:
                    System.out.println("**********OPCIÓN ORDENAR**********");
                    cola.ordenar();
                    System.out.println("COLA ORDENADA POR CODIGO DE ID");
                    
                    break;

                case 4:
                    System.out.println("**********OPCIÓN DESORDENAR**********");
                    cola.desordenar();
                    System.out.println("COLA DESORDENADA POR POR CODIGO DE ID");
                    
                    break;

                case 5:
                    System.out.println("**********OPCIÓN ELIMINAR**********");
                    System.out.print("Ingrese el numero del codigo de identificacion del Estudiante a eliminar: ");
                    int eliminar = in.nextInt();
                    
                    if(cola.eliminar(eliminar)){
                        System.out.println("El estudiante con codigo "+eliminar+" fue eliminado");
                    }else {
                        System.out.println("El estudiante con codigo "+eliminar+" no se encuentra en la cola");
                    }
                    
                    
                    break;

                case 6:
                    in = new Scanner(System.in);
                    System.out.println("*********OPCIÓN INSERTAR**********");

                    System.out.print("Ingrese el nombre del Estudiante: ");
                    String nombreIn = in.nextLine();
                  

                    System.out.print("Ingrese el numero de identificacion del Estudiante: ");
                    int numeroCodIdIn = in.nextInt();

                    

                    Estudiante nuevoIn = new Estudiante(nombreIn,  numeroCodIdIn);

                    int pos = 0;
                    do{
                        in = new Scanner(System.in);
                        System.out.print("Ingrese la index de posición donde se debe insertar el Estudiante: ");
                        pos = in.nextInt();
                        
                        if(pos > cola.gettamanyoCola()){
                            System.out.println("La posición ingresada es mayor a la cantidad de estudiantes en la cola");
                        }
                    }while(pos < 0 || pos > cola.gettamanyoCola());
                    
                    cola.insertar(pos, nuevoIn);
                    
                    
                    System.out.println("ESTUDIANTE INSERTADO EN LA POSICION ["+pos+"]");
                    
                    break;

                case 7:
                    System.out.println("**********OPCIÓN RECORRER DE INICIO A FIN**********");
                    cola.recorrerDEinicioAFin();
                    
                    
                    break;

                case 8:
                    System.out.println("**********OPCIÓN RECORRER DE FIN A INICIO**********");
                    cola.recorrerDEfinAIniciio();

                    
                    break;

                case 9:
                    System.out.println("**********OPCION IMPRIMIR**********");
                    cola.imprimir();
                    
                    break;

                       default:

                    break;
                    
            }
            

        } while (opcionUser != 10);

        in.close();
    }
}
