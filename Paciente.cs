
namespace jmatorrales.hospital
{
    class Paciente : Persona
    {
        
        public string diagnostico { get; set; }
        public int diasDeIngreso { get; set; }
        public char pronostico { get; set; }
        public List<string> medicamentos { get; set; }
        public List<string> pruebas { get; set; }
        public bool esPaciente { get; set; }

        public void altaPaciente()
        {

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
