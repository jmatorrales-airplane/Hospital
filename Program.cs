class Hospital
{
    public static void Main(String[] args)
    {
        
    }
}

class Persona
{
    public string nombre { get; set; }
    public string apellidos { get; set; }
    public int edad { get; set; }
}

class Paciente
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