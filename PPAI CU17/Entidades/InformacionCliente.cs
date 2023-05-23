using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class InformacionCliente
    {
        private string datoAValidar;


        public InformacionCliente(string datoAValidar)
        {
            this.datoAValidar = datoAValidar;

        }
        public string _datoAValidar
        {
            get => datoAValidar;
            set => datoAValidar = value;
        }
    }
        
}

