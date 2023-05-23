using PPAI_CU17.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU17
{
    public partial class InterfazOperador : Form
    {

        // declarar atributo gestor
        private gestorOperador gestor;
        // atributo llamadas que es una lista de llamadas
        private List<Llamada> llamadasSeleccionadas;
        private Llamada llamadaSeleccionada;

        public InterfazOperador()
        {
            InitializeComponent();
            gestor = new gestorOperador(this);
            llamadasSeleccionadas = new List<Llamada>();


        }

        private void InterfazOperador_Load(object sender, EventArgs e)
        {
            //buscar estado en curso
            int esEnCurso = gestor.esEnCurso();
            //esEnCurso tiene el numero identificador del estado "En Curso"

            gestor.seleccionarLlamadaIniciada();




          // crear nuevo cambio de estado con ese estado

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void mostrarDatos(String nombreCompleto, String dni, String categoria, String opcion, String subopcion)
        {
            txtNombre.Text = nombreCompleto;
            lblDNI.Text = dni;
            lblCategoria.Text = categoria;
            lblOpcion.Text = opcion;
            lblSubOpcion.Text = subopcion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string v1 = txtValidacion1.ToString();
            string v2 = txtValidacion2.ToString();
            string v3 = txtValidacion3.ToString();

            gestor.tomarOpcionValidacion( v1,  v2, v3);
        }
    }
}