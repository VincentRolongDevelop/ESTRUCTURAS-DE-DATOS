namespace Cola
{
    //Nombre de la clase
    public class Estudiante
    {
        //Atributos
        private string nombres;
        private int id, semestreBachiller;
       
        //Métodos
        public Estudiante(string nombres,int id,int semestreBachiller)
        {
            this.nombres = nombres;
            this.id = id;
            this.semestreBachiller = semestreBachiller;
           
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
      

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

       
        public int SemestreBachiller
        {
            get { return semestreBachiller; }
            set { semestreBachiller = value; }
        }

       
        public override string ToString()
        {
            return string.Format("Nombres: {0}\nId: {1}\nSemestre:{2}\n"
                , nombres, 
                id, semestreBachiller);
        }
    }
}