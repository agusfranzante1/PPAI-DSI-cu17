using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class Validacion
    {
        private int opcionMensajeValidacion;
        private string nombre;
        private int nroOrden;

        public Validacion(int opcionMensajeValidacion, string nombre, int nroOrden)
        {
            this.opcionMensajeValidacion = opcionMensajeValidacion;
            this.nombre = nombre;
            this.nroOrden = nroOrden;

        }
        public string _opcionMensajeValidacion
        {
            get => _opcionMensajeValidacion;
            set => _opcionMensajeValidacion = value;
        }
        public string _nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int _nroOrden
        {
            get => nroOrden;
            set => nroOrden = value;
        }
  

    }
}

