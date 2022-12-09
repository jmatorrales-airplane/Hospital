
namespace jmatorrales.hospital
{
    class Hospital
    {
        private List<string> camas = new List<string>();
        private Paciente paciente = new Paciente();

        private List<string> listaMedicamentos = new List<string>()
            { "aspirina", "rinotizol", "cascahueton", "filecodeina", "surnorteina" };

        private List<string> listaPruebas = new List<string>()
        { "rayosX", "TAC", "medida azucar", "prueba de esfuerzo", "escanner" };

        public void ingresarPaciente()
        {
            try
            {
                mostrar("Numero de cama a asignar:");
                string idCama = Console.ReadLine();
                mostrar("\nNombre del paciente:");
                string nombre = Console.ReadLine();
                Console.WriteLine("\nDireccion del paciente:");
                string direccion = Console.ReadLine();
                Console.WriteLine("\nDNI del paciente:");
                string dni = Console.ReadLine();
                Console.WriteLine("\nDiagnostico:");
                string diagnostico = Console.ReadLine();
                Console.WriteLine("\nDias de ingreso:");
                int diasDeIngreso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPronostico del paciente:  (G/M/L)");
                char pronostico = Console.ReadLine()[0];
                Console.WriteLine("\nMedicacion del paciente:");
                string medicacion = seleccionarMedicamento();
                Console.WriteLine("\nPruebas realizadas:");
                string pruebas = seleccionarPrueba();

                camas.Add(idCama);
                paciente.ingreso(nombre, direccion, dni, diagnostico, diasDeIngreso, pronostico, medicacion, pruebas);
            }
            catch(IOException ioex) { }
        }

        public void altaPaciente()
        {
            paciente.altaPaciente();
        }

        public void verCamas()
        {
            if(camas.Count > 0)
            {
                foreach (string cama in camas)
                {
                    Console.WriteLine(cama);
                }
            }
            else
            {
                Console.WriteLine("No hay camas asignadas");
            }
        }

        private string seleccionarMedicamento()
        {
            int n = 1;
            mostrar("Indica el medicamento utilizado");
            foreach(string medicamento in listaMedicamentos)
            {
                Console.Write($"{n}. {medicamento} ");
                n++;
            }
            Console.WriteLine(" ");
            try
            {
                int opcion = Convert.ToInt32(Console.ReadLine());

                if(opcion > 0) return listaMedicamentos[opcion - 1];
                else
                {
                    mostrar("Opcion no valida, vuelva a intentarlo");
                    seleccionarMedicamento();
                }
            }catch(Exception ex) {}
            return null;
        }

        private string seleccionarPrueba()
        {
            int n = 1;
            mostrar("Indica la prueba realizada");
            foreach (string prueba in listaPruebas)
            {
                Console.Write($"{n}. {prueba} ");
                n++;
            }
            Console.WriteLine(" ");
            try
            {
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion > 0) return listaPruebas[opcion - 1];
                else
                {
                    mostrar("Opcion no valida, vuelva a intentarlo");
                    seleccionarPrueba();
                }
            }
            catch (Exception ex) { }
            return null;
        }

        private void mostrar(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
