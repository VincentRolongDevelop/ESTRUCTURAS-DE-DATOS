using System;

namespace Mapa
{
    class Program
    {
        //MÉTODO MAIN
        static void Main(string[] args)
        {
            //Instancia de mapa
            Mapa mapa = new Mapa();

        //Inicio del programa
        mapa.agregar("amigo", "Que mantiene una relación de amistad con otra u otras personas.");
        mapa.agregar("inteligencia", "Facultad de la mente que permite aprender, entender, razonar, tomar decisiones y formarse una idea determinada de la realidad.");
        mapa.agregar("vejez", "Último período de la vida de una persona, que sigue a la madurez, y en el cual se tiene edad avanzada");
      
        mapa.imprimir();

        String eliminar1 = new String("amigo");
        Console.WriteLine("************************************************");
        Console.WriteLine("ELIMINANDO PALABRA amigo");
        mapa.eliminar(eliminar1);
        Console.WriteLine("************************************************");

        mapa.imprimir();

        Console.WriteLine("*Buscando una palabra en el mapa*");
        Console.WriteLine("vejez");
        Console.WriteLine("************************************************");
        String buscaDato = new String("vejez");
        String buscar = mapa.buscar(buscaDato);
        if(buscar != null){
            Console.WriteLine("La palabra indicada como " + buscaDato + " esta almacenada en el mapa");
            Console.WriteLine(buscaDato+": "+buscar);
        }else{
            Console.WriteLine("La palabra indicada como " + buscaDato + " no esta en el mapa");
        }
        
        Console.WriteLine("************************************************");
        Console.WriteLine("*MAPA ORDENADO*");
        Console.WriteLine("************************************************");
        mapa.ordenar();
        mapa.imprimir();
        
        Console.WriteLine("************************************************");
        Console.WriteLine("*MAPA DESORDENADO*");
        Console.WriteLine("************************************************");
        mapa.desordenar();
        mapa.imprimir();
                
         
        Console.WriteLine("************************************************");
        Console.WriteLine("*INSERTAR DATO A MAPA*");
        Console.WriteLine(" Se inserta = 'avion'");
        Console.WriteLine("----Su definición seria = 'Aeronave más pesada que el aire , provista de alas , cuya sustentación y avance son consecuencia de la acción de uno o varios motores '");
        Console.WriteLine("************************************************");
        String insertar = new String("avion");
        String significado = new String("Aeronave más pesada que el aire , provista de alas , cuya sustentación y avance son consecuencia de la acción de uno o varios motores ");
        mapa.insertar(insertar, significado);
        mapa.imprimir();
       
        Console.WriteLine("************************************************");
        Console.WriteLine("*RECORRER DE INICIO A FIN*");
        Console.WriteLine("************************************************");
        mapa.recorridoDeinicioAFin();
        
        Console.WriteLine("************************************************");
        Console.WriteLine("*RECORRER DE FIN A INICIO*");
        Console.WriteLine("************************************************");
        mapa.recorridoDeFinAInicio();
        
        }
    }
}
