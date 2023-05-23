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

        //instanciamos la clase de la interfaz

        private InterfazOperador pantalla;

        //metodo constructor con inicializacion atributos

        public gestorOperador(InterfazOperador consultarLlamadas)
        {



            //AGREGAMOS LOS ESTADOS

            estados.Add(new Estado("En Curso"));
            estados.Add(new Estado("Finalizada"));


            //Generamos un Cambio de Estado

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



            // Crear objetos -------------------------------------------------------------------------------------------------------------------------------

            // Subopciones
            subopcionLlamada.Add(new sub_opcionLlamada("subopcion 1", "Generar Reclamo", 1, "Audio Generar Reclamo"));


            // Opciones
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 1", "Informar y Pedir Tarjeta", 1, "Audio Informar y Pedir Tarjeta", new List<sub_opcionLlamada> { subopcionLlamada[0]}));
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 1", "Informar y Anular", 1, "Audio Informar y Anular Cuenta", new List<sub_opcionLlamada> {}));

            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 1", "Informar y Blanquear", 1, "Audio Informar y Blanquear Cuenta", new List<sub_opcionLlamada> { }));
            opcionllamadaEncontradas.Add(new OpcionLlamada("opcion 1", "Informar", 1, "Audio Informar", new List<sub_opcionLlamada> { }));


            // Creando las Categorias
            categoriasllamadaencontradas.Add(new CategoriaLlamada("Robo","Categoria Robo", "1", "Audio Robo", new List<OpcionLlamada>{ opcionllamadaEncontradas[0], opcionllamadaEncontradas[1]}));
            categoriasllamadaencontradas.Add(new CategoriaLlamada("Bloqueo", "Categoria Robo", "2", "audio2", new List<OpcionLlamada> { opcionllamadaEncontradas[2], opcionllamadaEncontradas[3] }));


            //Creando Clientes

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

                Cliente cliente = new Cliente(dni, nombre, numeroCelular);
                clientes.Add(cliente);
                //Crea el Cliente
            }


            //

            for (int i = 1; i <= 9; i++)
            {
                respuestasPosibles.Add(new RespuestaPosible("Respuesta " + i, (i - 1) % 3 + 1));
            }

            preguntas.Add(new Pregunta("Pregunta 1", new List<RespuestaPosible> { respuestasPosibles[0], respuestasPosibles[1], respuestasPosibles[2] }));
            preguntas.Add(new Pregunta("Pregunta 2", new List<RespuestaPosible> { respuestasPosibles[3], respuestasPosibles[4], respuestasPosibles[5] }));
            preguntas.Add(new Pregunta("Pregunta 3", new List<RespuestaPosible> { respuestasPosibles[6], respuestasPosibles[7], respuestasPosibles[8] }));

            // crea 2 encuestas con preguntas diferentes

            encuestas.Add(new Encuesta("Encuesta 1", DateTime.Now.AddDays(1), new List<Pregunta> { preguntas[0], preguntas[1] }));
            encuestas.Add(new Encuesta("Encuesta 2", DateTime.Now.AddDays(1), new List<Pregunta> { preguntas[1], preguntas[2] }));

            respuestasDeClientes.Add(new RespuestaDeCliente(DateTime.Now, respuestasPosibles[0]));
            respuestasDeClientes.Add(new RespuestaDeCliente(DateTime.Now, respuestasPosibles[3]));
            respuestasDeClientes.Add(new RespuestaDeCliente(DateTime.Now, respuestasPosibles[1]));
            respuestasDeClientes.Add(new RespuestaDeCliente(DateTime.Now, respuestasPosibles[4]));
            respuestasDeClientes.Add(new RespuestaDeCliente(DateTime.Now, respuestasPosibles[2]));
            respuestasDeClientes.Add(new RespuestaDeCliente(DateTime.Now, respuestasPosibles[5]));



            //instanciamos la funcion para crear 3 llamadas

            llamadas.Add(CrearLlamada());
            llamadas.Add(CrearLlamada());
            llamadas.Add(CrearLlamada());

            this.pantalla = consultarLlamadas;
        }

        //Creamos las Llamadas

        Llamada CrearLlamada()
        {
            Random random = new Random();

            // Obtener un cliente aleatorio que no se haya utilizado previamente
            Cliente clienteAleatorio = clientes[random.Next(clientes.Count)];



            // Crear objeto de la clase "Llamada" con valores aleatorios y únicos
            Llamada llamada = new Llamada("Descripción operador", "Detalle acción requerida", random.Next(0, 1001), true, "Observación auditor", clienteAleatorio);

            llamada._cambiosDeEstados.Add(cambiosEstado[random.Next(cambiosEstado.Count)]);
            llamada._cambiosDeEstados.Add(cambiosEstado[8]);

            llamada._respuestasDeEncuestas.Add(respuestasDeClientes[0]);
            llamada._respuestasDeEncuestas.Add(respuestasDeClientes[1]);

            return llamada;
        }



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
        public List<RespuestaDeCliente> _respuestasDeClientes
        {
            get => respuestasDeClientes;
            set => respuestasDeClientes = value;
        }
        public List<Pregunta> _preguntas
        {
            get => preguntas;
            set => preguntas = value;
        }
        public List<Encuesta> _encuestas
        {
            get => encuestas;
            set => encuestas = value;
        }
        public List<RespuestaPosible> _respuestasPosibles
        {
            get => respuestasPosibles;
            set => respuestasPosibles = value;
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



        // metodo llamado "consultarEncuesta()" que le envia un mensaje llamado "solicitarPeriodoLlamada"
        // a la pantalla "ConsultarLlamadas"
        public void consultarEncuesta()
        {
            // como identifico la ventana activa?
            // como le envio el mensaje a la ventana activa?


            // como le envio el mensaje a la ventana "ConsultarLlamadas"? 
            pantalla.solicitarPeriodoLlamada();


        }

        //metodo "fechaInicioYFinSeleccionadas" que recibe 2 parametros de tipo DateTime y los guarda en 2 variables locales e instancia el metodo buscarLLamadasDelPeriodoRespondidas() pasandole las 2 variables locales como parametros
        public void fechaInicioYFinSeleccionadas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // guarda los parametros en variables locales
            fechaDesdeLocal = fechaDesde;
            fechaHastaLocal = fechaHasta;
            // instancia el metodo buscarLLamadasDelPeriodoRespondidas() pasandole las 2 variables locales como parametros
            buscarLLamadasDelPeriodoRespondidas(fechaDesdeLocal, fechaHastaLocal);
        }


        public void buscarLLamadasDelPeriodoRespondidas(DateTime fechaDesde, DateTime fechaHasta)
        {
            llamadasEncontradas = new List<Llamada>();
            // crea un bucle para recorrer todas las llamadas y verificar si estan respondidas y son de un periodo dado
            // si es asi las agrega a la lista de llamadas encontradas, el metodo para validar si tiene una respuesta es "tieneRespuestaDeCliente"
            foreach (Llamada llamada in llamadas)
            {
                if (llamada.tieneRespuestaDeCliente() && llamada.esDePeriodo(fechaDesde, fechaHasta))
                {
                    llamadasEncontradas.Add(llamada);
                }
            }
            pantalla.pedirSeleccionLlamada(llamadasEncontradas);
        }

        public void llamadaSeleccionada(int indexLlamada)
        {

            mostrarLlamada(llamadasEncontradas[indexLlamada]);
        }

        public void mostrarLlamada(Llamada llamadaSeleccionada)
        {
            // obtener todos los atributos del cliente de la llamada seleccionada
            string nombreCliente = llamadaSeleccionada._cliente._nombreCompletoCliente;
            string dniCliente = llamadaSeleccionada._cliente._dniCliente.ToString();
            string celularCliente = llamadaSeleccionada._cliente._numeroCelularCliente;
            string duracionLlamada = llamadaSeleccionada._duracion.ToString();
            string estadoActual = llamadaSeleccionada.getEstadoActual()._nombre;

            List<Pregunta> preguntasDeLaLlamada = new List<Pregunta>();
            preguntasDeLaLlamada = llamadaSeleccionada.obtenerPreguntas(preguntas);
            MessageBox.Show(preguntasDeLaLlamada[0]._pregunta);

            Encuesta encuestaEncontrada = new Encuesta();
            foreach (var encuesta in encuestas)
            {
                if (encuesta.sonTusPreguntas(preguntas))
                {
                    encuestaEncontrada = encuesta;
                }
            }
            List<String> listaPreguntas = new List<String>();
            List<String> listaRespuestas = new List<String>();
            foreach (var pregunta in encuestaEncontrada._preguntas)
            {
                listaPreguntas.Add(pregunta._pregunta);
            }
            foreach (var respuesta in llamadaSeleccionada._respuestasDeEncuestas)
            {
                listaRespuestas.Add(respuesta._respuestaSeleccionada._descripcion);
            }
            if (listaPreguntas.Count == 0)
            {
                MessageBox.Show(encuestaEncontrada._descripcion);

            }
            // enviar a la pantalla los datos del cliente y la llamada con el metodo pedirSeleccionGeneracionCsv()
            pantalla.pedirSeleccionGeneracionCsv(nombreCliente, dniCliente, celularCliente, estadoActual, duracionLlamada, listaPreguntas, listaRespuestas);

        }

        public void opcionCsvSeleccionada()
        {
            return;
        }
    }
}
