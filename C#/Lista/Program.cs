using System;

namespace Lista
{
    class Program
    {
        //Método main
        static void Main(string[] args)
        {
            //Creación de lista
            Lista lista = new Lista();
            //Agregando datos a la lista
            lista.agregarDato("CHEVROLET");
            lista.agregarDato("BMV");
            lista.agregarDato("MERCEDES-BENZ");
            lista.agregarDato("AUDI");
            lista.agregarDato("RENAULT");
            lista.agregarDato("FORD");
            lista.agregarDato("HYUNDAI");
            lista.agregarDato("MAZDA");

            Console.WriteLine("********************************");
            Console.WriteLine("Buscando 'CHEVROLET': ");
            Console.WriteLine("********************************");
            if(lista.buscarDato("CHEVROLET") != null){
                Console.WriteLine("Encontrado");
                Console.WriteLine("");
                
            }else{
                Console.WriteLine("No encontrado");
            } 

            //Uso de métodos
            Console.WriteLine("Lista ingresada originalmente: ");
            
            lista.imprimirLista();

            Console.WriteLine("\nLista ordenada: ");
            lista.ordenarDatos();
            lista.imprimirLista();

            Console.WriteLine("\nLista desordenada: ");
            lista.desordenarListaReversa();
            lista.imprimirLista();

            
            Console.WriteLine("\nLista con un auto nuevo insertado");
            lista.insertarDatos(1, "JAC");
            lista.imprimirLista();

            Console.WriteLine("\nLista con el CHEVROLET eliminado");
            lista.eliminarDatoLista("CHEVROLET");
            lista.imprimirLista();

            Console.WriteLine("********************************");
            Console.WriteLine("Buscando 'CHEVROLET': ");
            Console.WriteLine("********************************");
            if(lista.buscarDato("CHEVROLET") != null){
                Console.WriteLine("Encontrado");
            }else{
                Console.WriteLine("No encontrado");
            } 

            lista.ordenarDatos();
            Console.WriteLine("\nLista recorrida de fin a inicio: ");
            lista.recorridoFinInicio();
            Console.WriteLine("\nLista recorrido de inicio a fin: ");
            lista.recorrerDeInicioFin();
        }
    }
}
