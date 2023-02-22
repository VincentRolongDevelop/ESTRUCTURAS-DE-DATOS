using System;

namespace Pila
{
    //Nombre de la clase
    class Program
    {
        //Método main
        static void Main(string[] args)
        {
            //Instancia de la pila
            Pila pila = new Pila();

           //Inicio de programa
            int opcionUser = 0;
            do
            {
                Console.WriteLine("******MENU PARA LOS DATOS, ¿QUE DESEA HACER EN LA PILA?*******");
                Console.WriteLine("1. Agregar dato");
                Console.WriteLine("2. Eliminar dato");
                Console.WriteLine("3. Ordenar datos");
                Console.WriteLine("4. Desordenar datos");
                Console.WriteLine("5. Buscar dato");
                Console.WriteLine("6. Insertar dato");
                Console.WriteLine("7. Recorrer la coleccion de INICIO A FIN");
                Console.WriteLine("8. Recorrer la coleccion de FIN A INICIO");
                Console.WriteLine("9. Imprimir colección entera con sus datos");
                Console.WriteLine("10. Salir del programa");
                Console.WriteLine("***********************************");

                try
                {
                    Console.Write(":");
                    opcionUser = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción de usuario invalida");
                    opcionUser = 0;
                }

                switch (opcionUser)
                {
                    case 1:
                        Console.WriteLine("*******OPCIÓN 1 AGREGAR**********");
                        Console.Write("Ingrese la marca del carro: ");
                        string marca = Console.ReadLine();;
                       
                        Console.Write("Ingrese el codigo de la placa del carro: ");
                        string placa = Console.ReadLine();;
                        Carro carro1 = new Carro(marca,placa.ToUpper());
                        pila.agregarDato(carro1);
                        Console.WriteLine("*********************************");
                        break;

                    case 2:

                    Console.WriteLine("**********OPCIÓN 2 ELIMINAR**********");
                        Console.Write("Ingrese la placa del carro: ");
                        string eliminar = Console.ReadLine();
                        pila.eliminarDato(eliminar.ToUpper());
                        Console.WriteLine("*********************************");
                        break;
                        

                    case 3:
                        Console.WriteLine("**********OPCIÓN 3 ORDENAR**********");
                        pila.ordenar();
                        Console.WriteLine("PILA ORDENADA POR CODIGO DE PLACA");
                        Console.WriteLine("*********************************");
                        break;

                    case 4:
                        Console.WriteLine("**********OPCIÓN 4 DESORDENAR**********");
                        pila.desordenar();
                        Console.WriteLine("PILA DESORDENADA POR CODIGO DE PLACA");
                        Console.WriteLine("****************************************");
                        break;

                    case 5:
                        Console.WriteLine("**********OPCIÓN 5 BUSCAR**********");
                        Console.Write("Ingrese el codigo de la placa del carro: ");
                        string datoBusco = Console.ReadLine();;
                        int indice = pila.buscarPorCodigo(datoBusco);
                        if (indice != -1)
                        {
                            Console.WriteLine("El carro indicado se encuentra en la posición [" + indice + "]");
                            pila.imprimir(indice);
                        }
                        else
                        {
                            Console.WriteLine("El carro no esta la colección");
                        }
                        Console.WriteLine("**********************************");
                        break;

                    case 6:
                        Console.WriteLine("**********OPCIÓN 6 INSERTAR**********");
                        Console.Write("Ingrese la marca del carro: ");
                        string marcaIn = Console.ReadLine();
                        
                        Console.Write("Ingrese el codigo de la placa del carro: ");
                        string placaIn = Console.ReadLine();
                        Carro nuevoIn = new Carro(marcaIn, placaIn.ToUpper());
                        Console.Write("Ingrese la posición donde desea insertar el Carro dentro de la pila: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        pila.insertarDato(pos, nuevoIn);
                        Console.WriteLine("**************************************");
                        break;

                    case 7:
                        Console.WriteLine("**********RECORRER DE INICIO A FIN LA PILA**********");
                        pila.recorrerDeInicioFin();
                        Console.WriteLine("***************************************************");
                        break;

                    case 8:
                        Console.WriteLine("**********RECORRER DE FIN A INICIO LA PILA**********");
                        pila.recorrerDeFinInicio();
                        Console.WriteLine("****************************************************");
                        break;

                    case 9:
                        Console.WriteLine("**********IMPRIMIR LA PILA**********");
                        pila.imprimir();
                        Console.WriteLine("************************************");

                        break;

                    default:

                        break;
                }

            } while (opcionUser != 10);
        }
    }
}
