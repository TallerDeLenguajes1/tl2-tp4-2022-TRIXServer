using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_TRIXServer.Models
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private List<Cadete> cadetes;

        public Cadeteria()
        {
            var random = new Random();

            string fileCadeterias = "cadeterias.csv";
            var readFile = File.ReadAllLines(fileCadeterias);
            int randomCadeteria = random.Next(readFile.Length);
            var selectCadeteria = (readFile[randomCadeteria]).Split(", ");

            this.nombre = selectCadeteria[0];
            this.telefono = selectCadeteria[1];
            this.cadetes = new List<Cadete>();

        }

        public Cadeteria(string dataNombre, string dataTelefono)
        {
            this.nombre = dataNombre;
            this.telefono = dataTelefono;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

    }

    public class DBCadeteria
    {
        
    }

}