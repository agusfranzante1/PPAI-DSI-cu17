using PPAI_CU17.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Entidades
{
    public class Estado
    {

        private string nombre;

        public Estado(string nombre)
        {
            this.nombre = nombre;

        }
        public string _nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
    }
}