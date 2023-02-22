using System;
using System.Collections.Generic;

namespace Cola
{
    //Nombre de la clase
    public class Cola
    {
        //Uso de Queue
        
        private List<Estudiante> listaParaCola; 
        private Queue<Estudiante> cola1;
        private int tamanoCola;

        //Constructor
        public Cola(){
            this.cola1 = new Queue<Estudiante>();
            this.listaParaCola = new List<Estudiante>();
            this.tamanoCola = 0;
        }

        //Método agregar
        public void agregarEstudiante(Estudiante datoE)
        {
            this.cola1.Enqueue(datoE);
            this.tamanoCola++;
        }

         //Método eliminar
         public Boolean eliminarEstudiante(int ident){
            deColaAList();
            for (int i = 0; i < listaParaCola.Count; i++)
            {
                if (listaParaCola[i].Id == ident)
                {
                    listaParaCola.RemoveAt(i);
                    tamanoCola--;
                    deListACola();
                    return true;
                }
            }
            return false;
        }

        //Método para ordenar los datos
            public void ordenarIdEstudiante(){
            if (cola1 != null)
            {
                deColaAList();
                Estudiante [] arrayCola = listaParaCola.ToArray();
                Array.Sort(arrayCola, (Estudiante x, Estudiante y) => x.Id.CompareTo(y.Id));
                deArrayACola(arrayCola);
            }
        }

        //Método para ordenar
        public void desordenarIdEstudiante(){
            if (cola1 != null)
            {
                deColaAList();
                Estudiante [] arregloDeCola = listaParaCola.ToArray();
                Array.Sort(arregloDeCola, (Estudiante estudianteA, Estudiante estudianteB)=>estudianteB.Id - estudianteA.Id);
                deArrayACola(arregloDeCola);
            }
        }

        //Método buscar estudiante
        public Estudiante buscarEstudiante(int indent){
            deColaAList();
            for (int i = 0; i < listaParaCola.Count; i++)
            {
                if (listaParaCola[i].Id == indent)
                {
                    return listaParaCola[i];
                }
            }
            return null;
        }
       
        //Método para de cola a lista       

        public void deColaAList(){
            listaParaCola.Clear();
            foreach (Estudiante estudiante in cola1)
            {
                listaParaCola.Add(estudiante);
            }
        }

         //Método para de lista a cola  
        public void deListACola(){
            cola1.Clear();
            foreach (Estudiante estudiante in listaParaCola)
            {
                cola1.Enqueue(estudiante);
            }
        }

        //Método de arreglo a cola
        public void deArrayACola(Estudiante [] arreglo){
            cola1.Clear();
            for (int i = 0; i < arreglo.Length; i++)
            {
                cola1.Enqueue(arreglo[i]);
            }
        }

        //Método para insertar
        public void insertarDato(int auxPosicion, Estudiante estu){
            if (auxPosicion >= 0 && auxPosicion <= cola1.Count)
            {
                deColaAList();
                listaParaCola.Insert(auxPosicion, estu);
                deListACola();
            }
        }

        //Método para de inicio a fin
        public void recorrerDeInicioFin()
        {
            if (cola1 != null)
            {
                foreach (Estudiante estudiante in cola1)
                {
                    Console.WriteLine(estudiante.ToString());
                    Console.WriteLine("******************");
                }
            }
            else
            {
                Console.WriteLine("NO HAY DATOS EN LA COLA");
            }
        }

        //Método de fin a inicio
        public void recorrerDeFinInicio()
        {
            if (cola1 != null)
            {
                deColaAList();
                for (int i = listaParaCola.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(listaParaCola[i].ToString());
                    Console.WriteLine("******************");
                }
            }
            else
            {
                Console.WriteLine("NO HAY DATOS EN LA COLA");
            }
        }

        //Método para imprimir
        public void imprimirDatos()
        {
           
            foreach (Estudiante estudiante in cola1)
            {
                
                Console.WriteLine(estudiante.ToString());
                Console.WriteLine("******************");
            }
        }

        public int getSize()
        {
            return tamanoCola;
        }
    }
}