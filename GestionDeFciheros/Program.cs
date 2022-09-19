// See https://aka.ms/new-console-template for more information
using Archivos;
using static  System.Console;

//Variables

internal class Program
{
    
    private static void Main(string[] args)
    {

        bool seguir = true;
        string respuesta;

        Fichero file = new Fichero(FileMode.OpenOrCreate, nombre: "Personas.txt");

        //Variables de persona
        string nombre;
        int edad;
        string localidad;

        List<Persona> listPerson = new List<Persona>();
        WriteLine("Esto es una prueba de Ficheros");

        mostrarPersona(file);

        do
        {

            WriteLine("-------------------------------------------------------------------------------------------");
            WriteLine("Deseas introducir mas Personas? S/N");

            respuesta = ReadLine();

            if (respuesta.Trim().ToUpper() == "S")
            {

                nombre = pedirDatos("Nombre de la persona: ");
                while (!Int32.TryParse(pedirDatos("Edad de la persona: "), out edad));
                localidad = pedirDatos("Localidad de la persona: ");

                listPerson.Add(new Persona(nombre, edad, localidad));

            }
            else if (respuesta.Trim().ToUpper() == "N")
            {
                seguir = false;
            }
            else
            {
                WriteLine("Debes escribir S/N");
                WriteLine("-------------------------------------------------------------------------------------------");
            }

        }
        
         while (seguir);

        if (listPerson.Count() > 0)  file.guardarPersonas(listPerson);

        mostrarPersona(file);

    }

    private static void mostrarPersona(Fichero file)
    {

        Persona person;

        string[] lectura = file.ReadFile().Split(";");
        List<string> personas = (from persona in lectura where persona.Trim() != "" select persona).ToList();
        string[] datosPersonas;

        WriteLine("Personas almacenadas : ");

        if (personas.Count > 0)
        {
            foreach (string datos in personas)
            {

                datosPersonas = datos.Split("|");

                person = new Persona(nombre: datosPersonas[0], edad: Convert.ToInt32(datosPersonas[1]), localidad: datosPersonas[2]);
                WriteLine(person.ToString());

            }
        }
        
    }

    private static string pedirDatos(string dato)
    {
        string devolver = "";
        bool seguir = true;

        do
        {

            Write(dato);
            devolver = ReadLine();

            WriteLine();

            if(devolver.Trim() == String.Empty)
            {

                WriteLine("Por favor escriba los datos correctamente");

            }
            else
            {

                seguir = false;

            }


        } while (seguir);

        return devolver;
    }
}

