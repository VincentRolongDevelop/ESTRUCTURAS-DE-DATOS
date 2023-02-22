using System;
using System.Collections.Generic;

namespace Pila
{
    //Nombre clase
    public class Pila
    {
        private Stack<Carro> pila;
        private int tamanioPila;
        private List<Carro> listaPila;


        //Constructor
        public Pila()
        {
            pila = new Stack<Carro>();
            listaPila = new List<Carro>();
            tamanioPila = 0;
        }

        //Métodos
        public void agregarDato(Carro datoEntra)
        {
            pila.Push(datoEntra);
            listaPila.Add(datoEntra);
            Console.WriteLine("*********************************************************");
            Console.WriteLine("El carro de codigo " + datoEntra.getPlaca() + " fue agregado");
            Console.WriteLine("*********************************************************");
            tamanioPila++;
        }

         public void eliminarDato(string placa)
        {
            dePilaALista();
            int variaControl = 0;
            for (int i = 0; i < listaPila.Count; i++)
            {
                if (listaPila[i].getPlaca().Equals(placa))
                {
                    listaPila.RemoveAt(i);
                    tamanioPila--;
                    Console.WriteLine("Carro con codigo de placa " + placa + " fue eliminado");
                    variaControl = 0;
                    break;
                }
                else
                {
                    variaControl++;
                }
            }

            if (variaControl > 0)
            {
                Console.WriteLine("CODIGO DE PLACA NO ENCONTRADO");
            }
            deListaaPila();
        }

        public int buscarPorCodigo(string placa)
        {
            dePilaALista();
            for (int i = 0; i < listaPila.Count; i++)
            {
                if (listaPila[i].getPlaca().Equals(placa.ToUpper()))
                {
                    deListaaPila();
                    return i;
                }
            }
            deListaaPila();
            return -1;
        }

        public void dePilaALista()
        {
            tamanioPila = pila.Count;
            listaPila.Clear();
            while (tamanioPila != 0)
            {
                listaPila.Add(pila.Pop());
                tamanioPila--;
            }

            for (int i = 0; i < listaPila.Count; i++)
            {
                pila.Push(listaPila[i]);
            }
        }

        public void deListaaPila()
        {
            pila.Clear();
            for (int i = 0; i < listaPila.Count; i++)
            {
                pila.Push(listaPila[i]);
            }
        }

        public void ordenar()
        {
            dePilaALista();
            List<Carro> ayuda = new List<Carro>();
            int i = 0;
            int j = 0;
            while (i < tamanioPila)
            {
                for (j = 0; j < tamanioPila; j++)
                {
                    if (listaPila[i].getPlaca().CompareTo(listaPila[j].getPlaca()) < 0)
                    {
                        ayuda[i] = listaPila[i];
                        listaPila[i] = listaPila[j];
                        listaPila[j] = ayuda[i];
                    }
                }
                i++;
            }
            Console.WriteLine("CONJUNTO DE CARROS ORDENADOS");
            deListaaPila();
        }

        public void desordenar()
        {
            dePilaALista();
            List<Carro> listaPilaInv = new List<Carro>();
            for (int i = 0; i < tamanioPila; i++)
            {
                listaPilaInv[i] = listaPila[tamanioPila - 1 - i];
            }

            for (int i = 0; i < tamanioPila; i++)
            {
                listaPila[i] = listaPilaInv[i];
            }
            Console.WriteLine("CONJUNTO DE CARROS DESORDENADOS");
            deListaaPila();
        }

       

        public void insertarDato(int posicion, Carro datoEntra)
        {
            dePilaALista();
            tamanioPila = pila.Count;
            if (posicion >= 0 && posicion <= tamanioPila)
            {
                listaPila.Insert(posicion, datoEntra);
                if (posicion == 0)
                {
                    Console.WriteLine("Carro de placa " + datoEntra.getPlaca() + " ha sido insertado en el inicio de la colección");
                }
                Console.WriteLine("Carro de placa " + datoEntra.getPlaca() + " ha sido insertado en la posición [" + posicion + "] de la colección");
                tamanioPila++;
            }
            else
            {
                Console.WriteLine("posicion no valida en la pila");
            }
            deListaaPila();
        }

        public void recorrerDeInicioFin()
        {
            if(listaPila.Count > 0){
            
                for (int i = 0; i < listaPila.Count; i++)
                {
                    Console.WriteLine(listaPila[i].getPlaca());
                }
            }else{
                Console.WriteLine("La colección se encuentra vacia");
            }
        }

        public void recorrerDeFinInicio()
        {
            for (int i = listaPila.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(listaPila[i].getPlaca());
            }
        }

        public void imprimir()
        {
            for (int i = 0; i < listaPila.Count; i++)
            {
                Console.WriteLine(listaPila[i].mostrar());
            }
        }

        public void imprimir(int indice)
        {
            dePilaALista();
            if (indice >= 0 && indice < tamanioPila)
            {
                Console.WriteLine(listaPila[indice].getPlaca());
            }
        }
    }
}