using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        public Cliente cliente;
        public List<CategoriaLlamada> categoria;
        //public OpcionLlamada opcion;
        public List<CambioEstado> cambiosDeEstados;
        public string respuestaOperador;

        public Llamada(string descripcionOperador, Cliente cliente, List<CategoriaLlamada> categoria, string respuestaOperador)
        {
            this.descripcionOperador = descripcionOperador;
            this.cliente = cliente;
            this.categoria = categoria;
            this.descripcionOperador = descripcionOperador;
            this.cambiosDeEstados = new List<CambioEstado>();
            this.respuestaOperador = respuestaOperador;
        }
        public string _descripcionOperador
        {
            get => descripcionOperador;
            set => descripcionOperador = value;
        }
        public Cliente _cliente
        {
            get => cliente;
            set => cliente = value;
        }

        public List<CategoriaLlamada> _categoria
        {
            get => categoria;
            set => categoria = value;
        }

        public List<CambioEstado> _cambiosDeEstados 
        {
            get => cambiosDeEstados;
            set => cambiosDeEstados = value;
        }

        public string _respuestaOperador
        {
            get => respuestaOperador;
            set => respuestaOperador = value;
        }



        public bool esEstadoInicializado()
        {
            // busca el ultimo cambio de estado de la llamada

            CambioEstado ultimoCambioEstado = cambiosDeEstados[cambiosDeEstados.Count - 1];

            // lo guardo en un string convirtiendolo en String

            string nombreEstadoCambioEstado = ultimoCambioEstado._estado.ToString();

            // Comparo el resultado con el valor que necesito

            return nombreEstadoCambioEstado == "inicializado";
        }

        //BUSCAR OPCION CATEGORIA U OPCION


        public Estado getEstadoActual()
        {
            foreach (var i in cambiosDeEstados)
            {
                if (i._fechaHoraFin == null)
                {
                    return i._estado;
                }
            }
            return null;
        }

    }
}