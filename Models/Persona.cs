using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_TRIXServer.Models
{
    public class Persona
    {
        private int id_persona;
        private string nombre;
        private string apellido;
        private string direccion;

        public Persona()
        {
        }

        public Persona(int id_persona, string nombre, string apellido, string direccion)
        {
            this.Id_persona = id_persona;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        
    }
}