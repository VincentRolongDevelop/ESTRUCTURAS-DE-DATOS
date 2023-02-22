package JAVA.Pila;
//Nombre de la clase
public class Carro {

    //Atributos
    private String marca;
    private String placa;

    //Método constructor y getter, setter
    public Carro(String marca, String placa) {

        this.marca = marca;
        this.placa = placa;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }
   

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String toString() {
        return "*****************"+"\nMarca: " + marca + "\nPlaca: " 
        + placa+"\n*****************";
    }
}
