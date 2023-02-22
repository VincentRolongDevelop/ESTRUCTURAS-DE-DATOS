package JAVA.Lista;

import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;

//NOMBRE DE LA CLASE
public class Lista1{

        //Instancia de linkedList    
        private LinkedList<String> lista;
        
        //Métodos de la clase
        public Lista1(){
            lista = new LinkedList<String>();
        }

        public void agregarDato(String pais){
            lista.add(pais);
        }

        public String buscar(String pais){
            Iterator<String> iter = lista.iterator();
            while(iter.hasNext()){
                String objeto = iter.next();
                if(objeto.equals(pais)){
                    return objeto;
                }
            }
            return null;
        }

        public void ordenarDatos(){
            Collections.sort(lista);
        }

        public void desordenarDatos(){
            Collections.sort(lista, Collections.reverseOrder());
        }

        public void eliminarDatos(String pais){
            lista.remove(pais);
        }

        public void insertar(int pos, String pais){
            lista.add(pos, pais);
        }

        public void recorridoDeInicioaFin(){
            Iterator<String> it = lista.iterator();
            while(it.hasNext()){
                System.out.println(it.next());
            }
        }

        public void recorridoDeFinaInicio(){
            desordenarDatos();
            Iterator<String> it = lista.iterator();
            while(it.hasNext()){
                System.out.println(it.next());
            }
            ordenarDatos();
        }

        public void imprimir(){
            Iterator<String> it = lista.iterator();
            while(it.hasNext()){
                System.out.println(it.next());
            }
        }
    }