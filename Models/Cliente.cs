using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_TRIXServer.Models
{
    public class Cliente : Persona
    {
        private string referenciaDireccion;

        public string ReferenciaDireccion { get => referenciaDireccion; set => referenciaDireccion = value; }

        public Cliente() : base()
        {

        }

        public Cliente(int dataId, string dataNombre, string dataTelefono, string dataDireccion) : base(dataId, dataNombre, dataTelefono, dataDireccion)
        {
            this.referenciaDireccion = dataDireccion;

        }

    }
    
}