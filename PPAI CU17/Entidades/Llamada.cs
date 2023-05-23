using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;


        public Llamada(string descripcionOperador)
        {
            this.descripcionOperador = descripcionOperador;

        }
        public string _datoAValidar
        {
            get => descripcionOperador;
            set => descripcionOperador = value;
        }
    }

}