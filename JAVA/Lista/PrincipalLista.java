package JAVA.Lista;

public class PrincipalLista {
    public static void main(String[] args) {

        //Implementación de la clase lista1
        Lista1 lista = new Lista1();
        
        //Uso de metodos
        lista.agregarDato("COLOMBIA");
        lista.agregarDato("BRASIL");
        lista.agregarDato("ARGENTINA");
        lista.agregarDato("CHILE");
        lista.agregarDato("ECUADOR");
        lista.agregarDato("MEXICO");
        lista.agregarDato("ESTADOS UNIDOS");
        lista.agregarDato("CANADA");
        lista.agregarDato("JAPON");
        lista.agregarDato("RUSIA");

        //Verificación
        System.out.println("****************");
        System.out.println("Buscando RUSIA:");
        System.out.println("****************");

        if(lista.buscar("RUSIA")!=null){
            System.out.println("");
            System.out.println("el pais se encuentra en la lista");
            System.out.println("");

        }else{
            System.out.println("");
            System.out.println("el pais no se encuentra en la lista");
            System.out.println("");
        }

        System.out.println("Lista original: ");
        lista.imprimir();

        System.out.println("\nLista ordenada: ");
        lista.ordenarDatos();

        lista.imprimir();
        System.out.println("\nLista desordenada: ");
        lista.desordenarDatos();

        lista.imprimir();
        System.out.println("\nPais eliminado 'JAPON'");
        lista.eliminarDatos("JAPON");
        lista.imprimir();

         //Verificación
         System.out.println("Buscando JAPON:");

         if(lista.buscar("JAPON")!=null){
             System.out.println("el pais se encuentra en la lista Encontrado");
 
         }else{
             System.out.println(" el pais no se encuentra en la lista:");
 
         }

        System.out.println("\nPais insertado 'CHINA'");
        lista.insertar(1, "CHINA");
        lista.imprimir();
        lista.ordenarDatos();
     
        
        System.out.println("\nLista recorrido de inicio a fin: ");
        lista.recorridoDeInicioaFin();

        System.out.println("\nLista recorrido de fin a inicio: ");
        lista.recorridoDeFinaInicio();


    }
}