using System;
using System.Collections.Generic;

namespace Mapa
{
    //Nombre de la clase mapa
    public class Mapa
    {
        //Instancia de un mapa 
        private Dictionary<string, string> mapa;

        //Métodos de la clase
        public Mapa()
        {
            mapa = new Dictionary<string, string>();
        }

        public void agregar(string palabraUsada, string significado)
        {
            mapa.Add(palabraUsada, significado);
        }

        public string buscar(string palabraUsada)
        {
            return mapa[palabraUsada];
        }

        public void ordenar()
        {
            var valueDato = new List<string>(mapa.Keys);
            valueDato.Sort();

            var nuevoMapa = new Dictionary<string, string>();
            foreach (var valor in valueDato)
            {
                nuevoMapa.Add(valor, mapa[valor]);
            }
            mapa = nuevoMapa;
        }

        public void desordenar()
        {
            var valueDato = new List<string>(mapa.Keys);

            valueDato.Reverse();
            var nuevoMapa = new Dictionary<string, string>();

            foreach (var valor in valueDato)
            {
                nuevoMapa.Add(valor, mapa[valor]);
            }
            mapa = nuevoMapa;
        }

        public void eliminar(string palabraUsada)
        {

            mapa.Remove(palabraUsada);
        }

        public void insertar(string palabraUsada, string significado)
        {

            mapa.Add(palabraUsada, significado);
        }

        public void recorridoDeinicioAFin()
        {

            foreach (var palabraUsada in mapa)
            {
                Console.WriteLine(palabraUsada.Key+": "+palabraUsada.Value);
            }
        }

        public void recorridoDeFinAInicio()
        {
           
            Dictionary<string, string> ayuda = new Dictionary<string, string>(mapa);
            ayuda = mapa;

            var valueDato = new List<string>(ayuda.Keys);

            valueDato.Reverse();
            
            foreach (var valor in valueDato)
            {
                Console.WriteLine(valor+"----> "+ayuda[valor]);
            }

        }

        //Método para imprimir
        public void imprimir()
        {
            Console.WriteLine();
           
            Console.WriteLine("*******SIGNIFICADOS DE PALABRAS EN IDIOMAS*******");
           
            foreach (var palabraUsada in mapa)
            {
                Console.WriteLine(palabraUsada.Key+": "+palabraUsada.Value);
            }
           
                      
            Console.WriteLine();
        }
    }
}