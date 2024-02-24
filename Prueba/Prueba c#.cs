using System;

class Persona
{
    // Atributos de la clase Persona
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }

    // Constructor de la clase Persona
    public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
    {
        // Validar la información en el constructor
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || fechaNacimiento == DateTime.MinValue ||
            string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(direccion))
        {
            throw new ArgumentException("La información proporcionada no es válida.");
        }

        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
        Direccion = direccion;
    }
}

class Alumno : Persona
{
    // Atributos adicionales de la clase Alumno
    public string Carnet { get; set; }
    public DateTime FechaIngreso { get; set; }
}

class Profesor : Persona
{
    // Atributos adicionales de la clase Profesor
    public string Titulo { get; set; }

    // Método adicional de la clase Profesor
    public void AsignarCalificacion()
    {
        // Lógica para asignar calificación
    }
}

class Program
{
    static void Main()
    {
        // Crear instancias para probar las clases
        Persona persona = new Persona("John", "Doe", new DateTime(1990, 5, 15), "123456789", "123 Main St");
        Alumno alumno = new Alumno
        {
            Nombre = "Jane",
            Apellido = "Doe",
            FechaNacimiento = new DateTime(1995, 8, 20),
            Telefono = "987654321",
            Direccion = "456 Oak St",
            Carnet = "A12345",
            FechaIngreso = DateTime.Now
        };
        Profesor profesor = new Profesor
        {
            Nombre = "Dr. Smith",
            Apellido = "Johnson",
            FechaNacimiento = new DateTime(1980, 3, 10),
            Telefono = "555888999",
            Direccion = "789 Pine St",
            Titulo = "Ph.D. in Computer Science"
        };

        // Ejecutar métodos o realizar acciones con las instancias creadas
        profesor.AsignarCalificacion();

        // Definir clases adicionales para una institución educativa
        // - Clase Curso
        // - Clase Asignatura
        // - Clase Aula
        // - Clase Horario
    }
}
eb