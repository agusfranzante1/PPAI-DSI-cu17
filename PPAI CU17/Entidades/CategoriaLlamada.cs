using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class CategoriaLlamada
    {
        private string mensajesOpciones;
        private string nombre;
        private string nroOrden;
        private List<string> audioMensajeOpciones;


        public CategoriaLlamada(string mensajesOpciones, string nombre, string nroOrden, List<string> audioMensajeOpciones)
        {
            this.mensajesOpciones = mensajesOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.audioMensajeOpciones = audioMensajeOpciones;
        }
        public string _mensajesOpciones
        {
            get => mensajesOpciones;
            set => mensajesOpciones = value;
        }
        public string _valor
        {
            get => nombre;
            set => nombre = value;
        }

        public string _nroOrden
        {
            get => nroOrden;
            set => nroOrden = value;
        }
        public List<string> _audioMensajeOpciones
        {
            get => audioMensajeOpciones;
            set => audioMensajeOpciones = value;
        }


    }
}
