package JAVA.Cola;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.Queue;

//Nombre de la clase
public class Cola {

    //Atributos
    private Queue<Estudiante> cola;
    private Estudiante[] arregloCola;
    private int tamanyoCola;

    //Métodos
    public Cola() {
        this.cola = new LinkedList<>();
        this.tamanyoCola = 0;
    }

    public void agregar(Estudiante esti) {
        this.cola.add(esti);
        this.tamanyoCola++;
    }

    public boolean eliminar(int id) {
        for (Estudiante estudiante : cola) {
            if(estudiante.getCodigoIdentificacion() == id) {
                cola.remove(estudiante);
                tamanyoCola--;
                return true;
            }
        }
        return false;
    }

    public Estudiante buscar(int codigo) {
        deColaAArreglo();
        for (int i = 0; i < arregloCola.length; i++) {
            if (arregloCola[i].getCodigoIdentificacion() == codigo) {
                return arregloCola[i];
            }
        }
        return null;
    }

    public void ordenar() {
        if(cola != null) {
            deColaAArreglo();
            Arrays.sort(arregloCola, (Estudiante e1, Estudiante e2) -> e1.getCodigoIdentificacion() - e2.getCodigoIdentificacion());
            deArregloACola();
        }
    }

    public void desordenar() {
        if(cola != null) {
            deColaAArreglo();
            Arrays.sort(arregloCola, (Estudiante e1, Estudiante e2) -> e2.getCodigoIdentificacion() - e1.getCodigoIdentificacion());
            deArregloACola();
        }
    }

    
    public Estudiante[] deColaAArreglo() {
        arregloCola = new Estudiante[tamanyoCola];
        for (int i = 0; i < tamanyoCola; i++) {
            arregloCola[i] = cola.poll();
        }
        deArregloACola();
        return arregloCola;
    }

    public void deArregloACola() {
        if(arregloCola != null){
            cola.clear();
        }else if(cola != null){
            deColaAArreglo();
            cola.clear();
        }
        
        for (int i = 0; i < arregloCola.length; i++) {
            this.cola.add(arregloCola[i]);
        }
    }

    public void insertar(int posicion, Estudiante est) {
        if(cola != null){
            deColaAArreglo();
            Estudiante [] auxiliar = new Estudiante[arregloCola.length+1];

            if(posicion == 0){
                for (int i = 1, j = 0; j < arregloCola.length; i++, j++) {
                    auxiliar[i] = arregloCola[j];
                }
                auxiliar[posicion] = est;
            }

            if(posicion == arregloCola.length-1){
                for (int i = 0; i < arregloCola.length; i++) {
                    auxiliar[i] = arregloCola[i];
                }
                auxiliar[posicion+1] = auxiliar[posicion];
                auxiliar[posicion] = est;
            }

            if(posicion != 0 || posicion != tamanyoCola-1){
                Estudiante [] auxIzq = Arrays.copyOfRange(arregloCola, 0, posicion);
                Estudiante [] auxDer = Arrays.copyOfRange(arregloCola, posicion, arregloCola.length);
                for (int i = 0; i < auxIzq.length; i++) {
                    auxiliar[i] = auxIzq[i];
                }
                auxiliar[posicion] = est;
                for (int i = posicion+1, j = 0; i < auxiliar.length; i++, j++) {
                    auxiliar[i] = auxDer[j];
                }
            }
            arregloCola = auxiliar;
            tamanyoCola++;
            deArregloACola();
        }else{
            cola.add(est);
            tamanyoCola++;
        }
    }

    public void recorrerDEinicioAFin(){
        if(cola != null){
            for (Estudiante estudiante : cola) {
                System.out.println(estudiante.toString());
                System.out.println("********************************");
            }
        }else{
            System.out.println("La cola se encuentra vacia");
        }
    }

    public void recorrerDEfinAIniciio(){
        if(cola != null){
            deColaAArreglo();
            for (int i = tamanyoCola-1; i >= 0; i--) {
                System.out.println(arregloCola[i].toString());
                System.out.println("********************************");
            }
        }else{
            System.out.println("La cola se encuentra vacia");
        }
    }

    public void imprimir(){
        for (Estudiante estudiante : cola) {
            System.out.println(estudiante.toString());
            System.out.println("********************************");
        }
    }

    public int gettamanyoCola() {
        return tamanyoCola;
    }
}
