package JAVA.Mapa;

import java.util.Scanner;

//Nombre de la clase
public class PrincipalMapa {

    //Método main
    public static void main(String[] args) {
        Mapa mapa = new Mapa();
        Scanner in = new Scanner(System.in);

        mapa.agregar("amigo", "Que mantiene una relación de amistad con otra u otras personas.");
        mapa.agregar("inteligencia", "Facultad de la mente que permite aprender, entender, razonar, tomar decisiones y formarse una idea determinada de la realidad.");
        mapa.agregar("vejez", "Último período de la vida de una persona, que sigue a la madurez, y en el cual se tiene edad avanzada");
        mapa.imprimir();

       
        String eliminar1 = new String("amigo");
        System.out.println("\n************************************************\n");
        System.out.println("\nELIMINANDO LA PALABRA amigo\n");
        mapa.eliminar(eliminar1);
        System.out.println("\n************************************************\n");
  
        mapa.imprimir();

        System.out.println("*Buscando una palabra en el mapa*");
        System.out.println("vejez");
        System.out.println("************************************************");
        String buscaDato = new String("vejez");
        String busqueda = mapa.buscar(buscaDato);
        if(busqueda != null){
            System.out.println("La palabra indicada como " + buscaDato + " esta almacenada en el mapa");
            System.out.println(buscaDato+": "+busqueda);
        }else{
            System.out.println("La palabra indicada como " + buscaDato + " no esta en el mapa");
        }
     
        System.out.println("************************************************");
        System.out.println("*MAPA ORDENADO*");
        System.out.println("************************************************");
        mapa.ordenar();
        mapa.imprimir();
        

        System.out.println("************************************************");
        System.out.println("*DESORDENANDO EL MAPA*");
        System.out.println("************************************************");
        mapa.desordenar();
        mapa.imprimir();
                      
        
        System.out.println("************************************************");
        System.out.println("*INSERTAR DATO A MAPA*");
        System.out.println(" Se inserta = 'avion'");
        System.out.println("----Su definición seria = 'Aeronave más pesada que el aire , provista de alas , cuya sustentación y avance son consecuencia de la acción de uno o varios motores '");
        System.out.println("************************************************");
        String palabra = new String("avion");
        String significado = new String("Aeronave más pesada que el aire , provista de alas , cuya sustentación y avance son consecuencia de la acción de uno o varios motores");
        mapa.insertar(palabra, significado);
        mapa.imprimir();
        
        System.out.println("************************************************");
        System.out.println("*RECORRIDO DE INICIO A FIN*");
        System.out.println("************************************************");
        mapa.recorridoDeInicioAFin();
       
        System.out.println("************************************************");
        System.out.println("*RECORRIDO DE FIN A INICIO*");
        System.out.println("************************************************");
        mapa.recorridoDeFinAInicio();

        in.close();
    }
}
