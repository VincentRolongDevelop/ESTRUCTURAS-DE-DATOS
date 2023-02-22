package JAVA.Pila;

import java.util.Stack;
//Nombre de la clase
public class Pila {
    //Atributos
    private Stack<Carro> pila;
    private int tamano;
    private Carro [] arregloPila;
    
    //Constructor
    public Pila() {
        pila = new Stack<>();
        tamano = 0;
    }

    //Métodos 
    public void agregar(Carro objeto) {
        pila.push(objeto);
        System.out.println("Carro de placa "+objeto.getPlaca()+" fue agregado");
        tamano++;
    }


    public void eliminar(String placa){
        int variableControl = 0;
        for(int i = 0; i < tamano; i++){
            if(pila.get(i).getPlaca().equals(placa)){
                pila.remove(i);
                tamano--;
                System.out.println("Carro de placa "+placa+" fue eliminado");
                variableControl = 0;
                break;

            }else{
                variableControl++;
            }
        }

        if(variableControl > 0){
            System.out.println("Placa no encontrada en la pila");
        }
    }

    public int buscarPorPlaca(String placa){
        for(int i = 0; i < tamano; i++){
            if(pila.get(i).getPlaca().equals(placa.toUpperCase())){
                return i;
            }
        }
        return -1;
    }

    public void dePilaAArreglo(){
        arregloPila = new Carro[tamano];
        for(int i = 0; i < tamano; i++){
            arregloPila[i] = pila.get(i);
        }
    }

    public void deArregloAPila(){
        pila.clear();
        tamano = 0;
        for(int i = 0; i < arregloPila.length; i++){
            pila.push(arregloPila[i]);
            tamano++;
        }
    }

    public void ordenar(){
        dePilaAArreglo();
        Carro [] ayu = new Carro[tamano];
        int i = 0;
        int j = 0;
        while(i < tamano){
            for(j = 0; j < tamano; j++){
                if(arregloPila[i].getPlaca().compareTo(arregloPila[j].getPlaca()) < 0){
                    ayu[i] = arregloPila[i];
                    arregloPila[i] = arregloPila[j];
                    arregloPila[j] = ayu[i];
                }
            }
            i++;
        }
        System.out.println("PILA DE CARROS ORDENADA");
        deArregloAPila();
    }

    public void desordenar(){
        dePilaAArreglo();
        Carro [] arregloPilaInv = new Carro[tamano];
        for(int i = 0; i < tamano; i++){
            arregloPilaInv[i] = arregloPila[tamano - 1 - i];
        }
        
        for(int i = 0; i < tamano; i++){
            arregloPila[i] = arregloPilaInv[i];
        }
        System.out.println("PILA DE CARROS CARROS DESORDENADA");
        deArregloAPila();
    }

    

    public void insertar(int posicion, Carro objeto){
        if(posicion >= 0 && posicion < tamano){
            pila.add(posicion, objeto);
            if(posicion == 0){
                System.out.println("Carro de placa "+objeto.getPlaca()+" ha sido insertado a la cabeza de la colección pila");    
            }
            System.out.println("Carro de placa "+objeto.getPlaca()+" ha sido insertado en la posición ["+posicion+"] ");
            tamano++;
        }else{
            System.out.println("posicionicion no valida en la pila");
        }
    }

    public void recorrerDeinicioAFin(){
        for (int i = 0; i < tamano; i++) {
            System.out.println(pila.elementAt(i).getPlaca());
        }
    }

    public void recorrerDeFinAInicio(){
        for (int i = tamano - 1; i >= 0; i--) {
            System.out.println(pila.elementAt(i).getPlaca());
        }
    }

    public void imprimir() {
        for (int i = 0; i < tamano; i++) {
            System.out.println(pila.elementAt(i));
        }
    }

    public void imprimir(int indice) {
        System.out.println(pila.elementAt(indice));
    }
}
