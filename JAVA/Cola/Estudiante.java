package JAVA.Cola;
//Nombre de la clase
public class Estudiante {

    //Atributos
    private String nombres;
    private int CodigoIdentificacion;
    

    //Constructor
    public Estudiante(String nombres,  int CodigoIdentificacion) {
        this.nombres = nombres;
        this.CodigoIdentificacion = CodigoIdentificacion;
       
    }

    //Getter y setters    
    public String getNombre() {
        return nombres;
    }

    public void setNombre(String nombres) {
        this.nombres = nombres;
    }

    
    public int getCodigoIdentificacion() {
        return CodigoIdentificacion;
    }

    public void setCodigoIdentificacion(int CodigoIdentificacion) {
        this.CodigoIdentificacion = CodigoIdentificacion;
    }


    @Override
    public String toString() {
        return "Nombres: " + nombres + "\nNúmero de codigo "+ CodigoIdentificacion + " " ;
    }

}
