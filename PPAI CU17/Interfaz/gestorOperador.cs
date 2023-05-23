using PPAI_CU17.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU17
{
    internal class gestorOperador
    {
        private DateTime fechaDesdeLocal;
        private DateTime fechaHastaLocal;

        private List<Llamada> llamadas = new List<Llamada>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Estado> estados = new List<Estado>();
        private List<CambioEstado> cambiosEstado = new List<CambioEstado>();
        private List<Llamada> llamadasEncontradas = new List<Llamada>();
        private List<CategoriaLlamada> categoriasllamadaencontradas = new List<CategoriaLlamada>();
        private List<InformacionCliente> informacionClientesEncontrada = new List<InformacionCliente>();
        private List<OpcionLlamada> opcionllamadaEncontradas = new List<OpcionLlamada>();
        private List<sub_opcionLlamada> subopcionLlamada = new List<sub_opcionLlamada>();
        private List<Validacion> validacionesEncontradas = new List<Validacion>();
        private List<Llamada> llamadaIniciada = new List<Llamada>();

        private InterfazOperador interfazOp;


        //instanciamos la clase de la interfaz

        //metodo constructor con inicializacion atributos

        public gestorOperador(InterfazOperador consultarLlamadas)
        {



            // Agregamos los Estados que Utilizamos (podrian estar todos)

            estados.Add(new Estado("Iniciada"));
            estados.Add(new Estado("En Curso"));
            estados.Add(new Estado("Finalizada"));


            // Generamos Cambios de Estados Aleatorios

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Estado estadoAleatorio = estados[random.Next(estados.Count)];

                DateTime fechaInicio = DateTime.Now;

                DateTime? fechaFin = null;

                if (i < 5)
                {
                    fechaFin = fechaInicio.AddHours(random.Next(1, 24));
                }

                CambioEstado cambioEstado = new CambioEstado(fechaInicio, estadoAleatorio, fechaFin);

                cambiosEstado.Add(cambioEstado);

            }



            // Creamos los objetos -------------------------------------------------------------------------------------------------------------------------------

            // Sub-Opciones
            subopcionLlamada.Add(new sub_opcionLlamada("subopcion 1", "Generar Reclamo", 1, "Audio Generar Reclamo"));


            // Opciones
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 1", "Informar y Pedir Tarjeta", 1, "Audio Informar y Pedir Tarjeta", new List<sub_opcionLlamada> { subopcionLlamada[0]}));
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 2", "Informar y Anular", 1, "Audio Informar y Anular Cuenta", new List<sub_opcionLlamada> {}));
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 3", "Hablar con Operador", 1, "Audio Hablar con Operador", new List<sub_opcionLlamada> { }));


            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 1", "Informar y Blanquear", 1, "Audio Informar y Blanquear Cuenta", new List<sub_opcionLlamada> { }));
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 2", "Informar", 1, "Audio Informar", new List<sub_opcionLlamada> { }));
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 3", "Hablar con Operador", 1, "Audio Hablar con Operador", new List<sub_opcionLlamada> { }));


            // Categorias
            categoriasllamadaencontradas.Add(new CategoriaLlamada("Robo","Categoria Robo", "1", "Audio Robo", new List<OpcionLlamada>{ opcionllamadaEncontradas[0], opcionllamadaEncontradas[1], opcionllamadaEncontradas[2]}));
            categoriasllamadaencontradas.Add(new CategoriaLlamada("Bloqueo", "Categoria Robo", "2", "audio2", new List<OpcionLlamada> { opcionllamadaEncontradas[3], opcionllamadaEncontradas[4], opcionllamadaEncontradas[5] }));

            // Crear Validaciones--

            // Creando 4? Clientes
            for (int i = 0; i < 3; i++)
            {
                int dni = random.Next(10000000, 55555555);
                string nombre = "Cliente " + i.ToString();

                // Generacion Número de celular aleatorio
                string phoneNumber = "+";

                for (int b = 0; b < 8; b++)
                {
                    phoneNumber += random.Next(0, 10);
                }

                string numeroCelular = phoneNumber;

                //Crear Datos A Validar!!!!

                //Creamos Cliente
                Cliente cliente = new Cliente(dni, nombre, numeroCelular);
                clientes.Add(cliente);
            }


            // Instanciamos la funcion "Crear Llamada" creando 4 (una con el estado necesario para el CU)

            llamadas.Add(CrearLlamadaCU());
            llamadas.Add(CrearLlamada());
            llamadas.Add(CrearLlamada());
            llamadas.Add(CrearLlamada());

            this.interfazOp = consultarLlamadas;
        }

        // Creamos las Llamadas

        Llamada CrearLlamadaCU()
        {
            Random random = new Random();
            Cliente seleccionCliente = clientes[random.Next(clientes.Count)];
            Llamada llamada = new Llamada("Descripción operador", seleccionCliente, new List<CategoriaLlamada> { categoriasllamadaencontradas[random.Next(categoriasllamadaencontradas.Count)] }, "");

            //Cambio de Estado "iniciado"

            llamada._cambiosDeEstados.Add(cambiosEstado[0]);

            return llamada;
        }

        Llamada CrearLlamada()
        {
            Random random = new Random();

            // Obtener un cliente aleatorio//
            Cliente seleccionCliente = clientes[random.Next(clientes.Count)];


            // Crear objeto de la clase "Llamada" con valores Aleatorios
            Llamada llamada = new Llamada("Descripción operador", seleccionCliente,new List<CategoriaLlamada> {categoriasllamadaencontradas[random.Next(categoriasllamadaencontradas.Count)]},"");

            //Ver bien el Cambio de Estado Que se Agrego
            llamada._cambiosDeEstados.Add(cambiosEstado[random.Next(cambiosEstado.Count)]);
            llamada._cambiosDeEstados.Add(cambiosEstado[8]);

            return llamada;
        }

        //-------------------------------------------------------------------------------------------------------------------------


        //metodos get y set

        public List<Estado> _estados
        {
            get => estados;
            set => estados = value;
        }
        public List<CambioEstado> _cambiosEstado
        {
            get => cambiosEstado;
            set => cambiosEstado = value;
        }
        public List<Cliente> _clienteList
        {
            get => clientes;
            set => clientes = value;
        }
        public List<CategoriaLlamada> _categoriaLlamada
        {
            get => _categoriaLlamada;
            set => _categoriaLlamada = value;
        }
        public List<OpcionLlamada> _opcionLlamada
        {
            get => _opcionLlamada;
            set => _opcionLlamada = value;
        }
        public List<sub_opcionLlamada> _sub_opcionLlamada
        {
            get => subopcionLlamada;
            set => subopcionLlamada = value;
        }
        public List<Validacion> _validacionesEncontradas
        {
            get => validacionesEncontradas;
            set => validacionesEncontradas = value;
        }
        public List<Llamada> _llamadas
        {
            get => llamadas;
            set => llamadas = value;
        }
        public DateTime _fechaDesdeLocal
        {
            get => fechaDesdeLocal;
            set => fechaDesdeLocal = value;
        }
        public DateTime _fechaHastaLocal
        {
            get => fechaHastaLocal;
            set => fechaHastaLocal = value;
        }




        //Desarrollo de el CU

        //


        public void seleccionarLlamadaIniciada()
        {
            llamadaIniciada = new List<Llamada>();

            //selecciona una llamada con estado ¨inicializada¨

            foreach (Llamada llamada in llamadas) 
            {

                if (llamada.esEstadoInicializado())
                {
                    llamadaIniciada.Add(llamada);
                    DateTime fechaInicio = DateTime.Now;
                    tomadaPorOperador();
                }

             //interfazOp.mostrarDatosLlamada(llamadaIniciada);


            }
        }

        public void tomadaPorOperador()
        {
            llamadaIniciada[0]._cambiosDeEstados.Add(cambiosEstado[1]);

            buscarDatosLlamada();
        }

        public int esEnCurso()
         {
            //llamadaSeleccionada.getEstadoActual()._nombre;

            for (int i = 0; i < (estados.Count); i++)
            {
                string tipoEstado = estados[i].ToString();
                if (tipoEstado == "enCurso")
                {
                    return i;
                }

                else return 0;
            }
            return 0;
        }

        public void buscarDatosLlamada(Llamada llamadaIniciada)
        {
            string nombreCliente = llamadaIniciada._cliente._nombreCompletoCliente;
            string dniCliente = llamadaIniciada._cliente._dniCliente.ToString();
            string categoria = llamadaIniciada._categoria.ToString();
            string opcion = "3";
            string subopcion = "no aplica";

            interfazOp.mostrarDatos(nombreCliente, dniCliente, categoria, opcion, subopcion);
        }

        public void tomarOpcionValidacion(string v1, string v2, string v3)
  
        {
        }
    }     
}
