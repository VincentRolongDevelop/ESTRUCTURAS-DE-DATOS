//Nombre clase
public class Carro {

    //Atributos
    string marca, placa;

    //Constructor y getter, setter
    public Carro(string marca, string placa) {
        this.marca = marca;
        this.placa = placa;
    }

    public string getMarca() {
        return this.marca;
    }

   
    public string getPlaca() {
        return this.placa;
    }

    public void setMarca(string marca) {
        this.marca = marca;
    }
   
    public void setPlaca(string placa) {
        this.placa = placa;
    }

    public string mostrar() {
        return "*****************"+"\nMarca: " + marca + "\nPlaca: " 
        + placa+"\n*****************";
    }
}
