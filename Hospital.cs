
namespace jmatorrales.hospital
{
    class Hospital
    {
        private string[] camas { get; set; }
        private Paciente paciente { get; set; }

        private List<string> listaMedicamentos = new List<string>()
            { "aspirina", "rinotizol", "cascahueton", "filecodeina", "surnorteina" };

        private List<string> listaPruebas = new List<string>()
        { "rayosX", "TAC", "medida azucar", "prueba de esfuerzo", "escanner" };

        public void ingresarPaciente(string idCama)
        {
            string cama = idCama;

        }
    }
}
