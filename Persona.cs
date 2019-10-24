using System;

namespace RepoPeso      //una librería de clases contiene codigo el cual se puede utilizar en otros proyectos
{
    public abstract class Persona
    {
        public abstract int Id { get; set; }    
        public abstract string NoTel { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Email { get; set; }
        public abstract string Direccion { get; set; }
        public abstract string Peso { get; set; }



        public abstract void Mostrar_Datos(Persona p);      //los metodos y atributos abstractos se deben declarar en las clases heredadas
        public abstract string Obtener_Nombre(Persona p);
    


    }
}
