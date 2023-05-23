using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class sub_opcionLlamada
    {
        private string nombre;
        private string mensajeSubOpciones;
        private int nroOrden;
        private string audioMensajeSubOpciones;

        public sub_opcionLlamada(string nombre, string mensajeSubOpciones, int nroOrden, string audioMensajeSubOpciones)
        {
            this.nombre = nombre;
            this.mensajeSubOpciones = mensajeSubOpciones;
            this.nroOrden = nroOrden;
            this.audioMensajeSubOpciones = audioMensajeSubOpciones;
        }
        public string _nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string _mensajeSubOpciones
        {
            get => mensajeSubOpciones;
            set => mensajeSubOpciones = value;
        }

        public int _nroOrden
        {
            get => nroOrden;
            set => nroOrden = value;
        }
        public string _audioMensajeSubOpciones
        {
            get => audioMensajeSubOpciones;
            set => audioMensajeSubOpciones = value;
        }


    }
}
