using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class OpcionLlamada
    {
        private string nombre;
        private string mensajeSubOpciones;
        private int nroOrden;
        private List<string> audioMensajeSubOpciones;


        public OpcionLlamada(string nombre, string mensajeSubOpciones, int nroOrden, List<string> audioMensajeSubOpciones)
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
        public List<string> _audioMensajeSubOpciones
        {
            get => audioMensajeSubOpciones;
            set => audioMensajeSubOpciones = value;
        }


    }
}

