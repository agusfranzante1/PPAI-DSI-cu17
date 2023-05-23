using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAI_CU17.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estado;
        private DateTime? fechaHoraFin;


        public CambioEstado(DateTime fechaHoraInicio, Estado estado, DateTime? fechaHoraFin)
        {
            // iniciar el atributo FechaHoraInicio vacio

            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;

            // iniciar el atributo FechaHoraFin vacio

            this.fechaHoraFin = fechaHoraFin;

        }
        public DateTime _fechaHoraInicio
        {
            get => fechaHoraInicio;
            set => fechaHoraInicio = value;
        }

        public Estado _estado
        {
            get => estado;
            set => estado = value;
        }
        public DateTime? _fechaHoraFin
        {
            get => fechaHoraFin;
            set => fechaHoraFin = value;
        }



        public string esEstadoInicializada() 
        {
            string estadoString = estado.ToString();
            return estadoString;     
        }
    }
}
