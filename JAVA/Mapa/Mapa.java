package JAVA.Mapa;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.TreeMap;

//Nombre de la clase
public class Mapa {
    //Creación del mapa
    private Map<String, String> mapa;
    //Uso de TreeMap
    private TreeMap<String, String> mapaEnOrden, mapaEnDesorden;

    //Constructor
    public Mapa() {
        mapa = new HashMap<String, String>();
        mapaEnOrden = new TreeMap<String, String>();
        mapaEnDesorden = new TreeMap<String, String>();
    }

    //Métodos de la clase 
    public void agregar(String palabraUsada, String significado) {
        mapa.put(palabraUsada, significado);
    }

    public String buscar(String palabraUsada) {
        return mapa.get(palabraUsada);
    }

    //Método ordenar que aplica las claves del mapa
    public void ordenar() {
        String[] palabraUsadas = mapa.keySet().toArray(new String[mapa.keySet().size()]);

        Arrays.sort(palabraUsadas, (parte1, parte2) -> parte1.compareTo(parte2));
        
        for (int i = 0; i < palabraUsadas.length; i++) {
            mapaEnOrden.put(palabraUsadas[i], mapa.get(palabraUsadas[i]));
        }
        mapa = mapaEnOrden;
    }

    public void desordenar() {
        String[] palabraUsadas = mapa.keySet().toArray(new String[mapa.keySet().size()]);

        Arrays.sort(palabraUsadas, (parte1, parte2) -> parte2.compareTo(parte1));
        
        for (int i = 0; i < palabraUsadas.length; i++) {
            mapaEnDesorden.put(palabraUsadas[i], mapa.get(palabraUsadas[i]));
        }
        mapa = mapaEnDesorden;        
    }

    public void eliminar(String palabraUsada) {
        mapa.remove(palabraUsada);
    }

    public void insertar(String palabraUsada, String significado) {
        mapa.put(palabraUsada, significado);
    }

    public void recorridoDeInicioAFin() {
        for (Map.Entry<String, String> instancia : mapa.entrySet()) {
            System.out.println(instancia.getKey() + "----> " + instancia.getValue());
        }
    }

    public void recorridoDeFinAInicio() {
        String[] claves = new String[mapa.size()];
        claves = mapa.keySet().toArray(claves);
        for (int i = claves.length - 1; i >= 0; i--) {
            System.out.println(claves[i] + "---->" + mapa.get(claves[i]));
        }
    }

    public void imprimir() {
        System.out.println();
        System.out.println("*******SIGNIFICADOS DE PALABRAS EN IDIOMAS*********");
       
        for (Map.Entry<String, String> instancia : mapa.entrySet()) {
            System.out.println(instancia.getKey() + ": " + instancia.getValue());
        }
        System.out.println("*******SIGNIFICADOS DE PALABRAS EN IDIOMAS*********");
        System.out.println();
    }
}
