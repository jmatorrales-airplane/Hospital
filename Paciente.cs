
namespace jmatorrales.hospital
{
    class Paciente : Persona
    {
        
        private string diagnostico { get; set; }
        private int diasDeIngreso { get; set; }
        private char pronostico { get; set; }
        private List<string> medicamentos { get; set; }
        private List<string> pruebas { get; set; }
        private bool esPaciente { get; set; }

        public void altaPaciente()
        {
            if(esPaciente)
            {

            }
            else
            {
                Console.WriteLine("El nombre introducido no es paciente en el hospital");
            }
        }

        public void ingreso(string nombre, string direccion, string dni, string diagnostico, int diasDeIngreso, char pronostico, string medicacion, string pruebas)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.dni = dni;
            this.diagnostico = diagnostico;
            this.diasDeIngreso = diasDeIngreso;
            this.pronostico = pronostico;
            medicamentos.Add(medicacion);
            this.pruebas.Add(pruebas);
            esPaciente = true;
        }
    }
}
