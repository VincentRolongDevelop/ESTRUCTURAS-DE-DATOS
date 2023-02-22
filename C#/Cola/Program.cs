using System;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();

            int opcionUser = 0;
            do{
                Console.WriteLine("¿QUE DESEA HACER A LA COLA DE ESTUDIANTES?");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1. Agregar datos");
                Console.WriteLine("2. Eliminar datos");
                Console.WriteLine("3. Ordenar datos");
                Console.WriteLine("4. Desordenar datos");
                Console.WriteLine("5. Buscar dato dato");
                Console.WriteLine("6. Insertar datos");
                Console.WriteLine("7. Recorrer coleccion de INICIO A FIN");
                Console.WriteLine("8. Recorrer coleccion de FIN A INICIO");
                Console.WriteLine("9. Imprimir colección y sus datos");
                Console.WriteLine("10. Salir del programa");
                Console.WriteLine("-----------------------------------------");
                
                try
                {
                    Console.Write(":");
                    opcionUser = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("OPCIÓN NO VALIDA PARA ESTE SISTEMA");
                    opcionUser = 0;
                }

                switch (opcionUser)
                {
                    case 1:
                        Console.WriteLine("**********OPCIÓN 1 INGRESE PARA AGREGAR**********");
                        Console.Write("Nombre del Estudiante: ");
                        String nombres = Console.ReadLine();

                        Console.Write("Ingrese el id del Estudiante para identificarlo: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Ingrese el número del semestre que cursa el estudiante: ");
                        int semestre = Convert.ToInt32(Console.ReadLine());
                        Estudiante nuevoEstudiante = new Estudiante(nombres, id, semestre);
                        cola.agregarEstudiante(nuevoEstudiante);
                        break;

                        case 2:
                            Console.WriteLine("**********LA OPCIÓN 2 ELIMINAR**********");
                        Console.Write("Ingrese EL numero de identificacion del Estudiante a eliminar: ");
                        int eliminar = Convert.ToInt32(Console.ReadLine());

                        if (cola.eliminarEstudiante(eliminar))
                        {
                            Console.WriteLine("El estudiante con el numero de identificacion " + eliminar + " ha sido eliminado");
                        }
                        else
                        {
                            Console.WriteLine("El estudiante con el numero de identificacion " + eliminar + " no se encuentra en la cola");
                        }




                        break;

                    case 3:
                        Console.WriteLine("**********OPCIÓN 3 ORDENAR**********");
                        cola.ordenarIdEstudiante();
                        Console.WriteLine("COLA ORDENADA POR ID");
                        break;

                    case 4:
                        Console.WriteLine("**********OPCIÓN 4 DESORDENAR**********");
                        cola.desordenarIdEstudiante();
                       
                        break;

                    case 5:
                        Console.WriteLine("**********OPCIÓN 5 BUSCAR**********");
                        Console.Write("Ingrese la ID del Estudiante: ");
                        int busquedaDeId = Convert.ToInt32(Console.ReadLine());

                        Estudiante respuestaUser = cola.buscarEstudiante(busquedaDeId);

                        if (respuestaUser != null)
                        {
                            Console.WriteLine("El estudiante " + respuestaUser.Nombres + "  con Id " + respuestaUser.Id + " esta en la cola");
                        }
                        else
                        {
                            Console.WriteLine("El estudiante esta en la cola");
                        }
                        break;

                    case 6:
                        Console.WriteLine("**********OPCIÓN 6 INSERTAR**********");
                        Console.Write("Ingrese el nombre del Estudiante: ");
                        String nombresEscrito = Console.ReadLine();
                                               
                                                
                        Console.Write("Ingrese el numero de identificacion del Estudiante: ");
                        int idEscrita= Convert.ToInt32(Console.ReadLine());
                                                

                        Console.Write("Ingrese el semestre que cursa el Estudiante: ");
                        int semestreEscrito = Convert.ToInt32(Console.ReadLine());

                      
                        Estudiante nuevoEs = new Estudiante(nombresEscrito, idEscrita, semestreEscrito);

                        int aux = 0;
                        do
                        {
                            Console.Write("En que posición desea ingresar al estudiante?: ");
                            aux = Convert.ToInt32(Console.ReadLine());

                            if (aux > cola.getSize())
                            {
                                Console.WriteLine("La posición ingresada es mayor al tamaño de la cola");
                            }
                        } while (aux < 0 || aux > cola.getSize());

                        cola.insertarDato(aux, nuevoEs);

                        Console.WriteLine("ESTUDIANTE INSERTADO EN LA POSICION [" + aux + "]");
                       
                        break;

                    case 7:
                        Console.WriteLine("**********OPCIÓN 7 RECORRER DE INICIO A FIN**********");
                        cola.recorrerDeInicioFin();

                        
                        break;

                    case 8:
                        Console.WriteLine("**********OPCIÓN 8 RECORRER DE FIN A INICIO**********");
                        cola.recorrerDeFinInicio();

                        
                        break;

                    case 9:
                        Console.WriteLine("**********OPCIÓN 9 IMPRIMIR**********");
                        cola.imprimirDatos();
                       
                        break;

                    default:

                       break;
                }
            } while (opcionUser != 10);
        }
    }
}
