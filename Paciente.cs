
namespace jmatorrales.hospital
{
    class Paciente: Persona
    {
        Persona p = new Persona()
        {
            nombre = "",
            apellidos = "",
            edad = 0
        };
        public string diagnostico { get; set; }
        public int diasIngresado { get; set; }
        public char pronostico { get; set; }
        public string medicacion { get; set; }
        public string pruebas { get; set; }

        public void altaPaciente()
        {

        }
    }
}
