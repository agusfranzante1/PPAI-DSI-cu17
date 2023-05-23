using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class CategoriaLlamada
    {
        private string mensajesCategoria;
        private string nombre;
        private string nroOrden;
        private string audioMensajeOpciones;
        public List<OpcionLlamada> opcionesSeleccionada1;

        public CategoriaLlamada(string mensajesOpciones, string nombre, string nroOrden, string audioMensajeOpciones, List<OpcionLlamada> opcionesSeleccionada1)
        {
            this.mensajesCategoria = mensajesOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.audioMensajeOpciones = audioMensajeOpciones;
            this.opcionesSeleccionada1 = opcionesSeleccionada1;
        }
        public string _mensajesOpciones
        {
            get => mensajesCategoria;
            set => mensajesCategoria = value;
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
        public string _audioMensajeOpciones
        {
            get => audioMensajeOpciones;
            set => audioMensajeOpciones = value;
        }

        public List<OpcionLlamada> _opcionesSeleccionada1
        {
            get => opcionesSeleccionada1;
            set => opcionesSeleccionada1 = value;
        }


    }
}
