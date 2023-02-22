//Usos en el programa
using System;
using System.Collections.Generic;

namespace Lista
{

//Nombre de clase
    public class Lista
    {
        private List<string> lista1;

        //Constructor
        public Lista()
        {
            this.lista1 = new List<string>();
        }

        //Método agregar
        public void agregarDato(string carro)
        {
            lista1.Add(carro);
        }

        //Método eliminar
         public void eliminarDatoLista(string carro)
        {
            lista1.Remove(carro);
        }

        //Método buscar dato
        public string buscarDato(string carro)
        {
            return lista1.Find(x => x == carro);
        }


        //Método ordenar    
        public void ordenarDatos()
        {
            lista1.Sort();
        }

        //Método desordenar    
        public void desordenarListaReversa()
        {
            lista1.Reverse();
        }

        //Método	insertar Dato
        public void insertarDatos(int posicion, string carro)
        {
            lista1.Insert(posicion, carro);
        }

        //Método para recorrer de inicio a fin
        public void recorrerDeInicioFin()
        {
            foreach (string aux in lista1)
            {
                Console.WriteLine(aux);
            }
        }


        //Metodo para recorrer de fin a inicio
        public void recorridoFinInicio()
        {
            List<string> auxiliar = lista1;
            auxiliar.Reverse();
            foreach (string aux in auxiliar)
            {
                Console.WriteLine(aux);
            }
        }

        //Imprimir lista
        public void imprimirLista()
        {
            foreach (string aux in lista1)
            {
                Console.WriteLine(aux);
            }
        }
    }
}