using System;
using System.Collections.Generic;
using System.Text;

namespace RepoPeso
{
    public class Adolescente : Persona
    {
        public override int Id { get; set; }
        public override string NoTel { get; set; }
        public override string Nombre { get; set; }
        public override string Direccion { get; set; }
        public override string Email { get; set; }
        public override string Peso { get; set; }

        public override string Obtener_Nombre(Persona p)
        {
            return p.Nombre + " : "+ p.NoTel;
        }
        public override void Mostrar_Datos(Persona p)
        {
            throw new NotImplementedException();
        }


    }
}
