using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Fichero : IFichero
    {

        private readonly  string _ruta;
        private string _nombre;
        private FileStream _file;

        public Fichero(FileMode mode=FileMode.OpenOrCreate, string nombre = "Ejemplo.txt")
        {
            this._ruta =  Directory.GetCurrentDirectory();
            this._nombre = nombre;
        }

        public void cerrarFichero()
        {
            this._file.Close(); 
        }

        public string ReadFile()
        {

            string devolver = "";

            try
            {

                using (FileStream fsSource = new FileStream(this._ruta + "\\" + this._nombre, FileMode.OpenOrCreate, FileAccess.Read))
                {

                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                   devolver = ASCIIEncoding.ASCII.GetString(bytes, 0, numBytesToRead);
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }

            return devolver;

        }

        public void guardarPersonas(List<Persona> listPerson)
        {

            using (FileStream fsSource = new FileStream(this._ruta + "\\" + this._nombre, FileMode.Append, FileAccess.Write))
            {

                string linea;

                foreach (Persona persona in listPerson)
                {

                    linea = persona.getNombre() + "|" + persona.getEdad() + "|"  +persona.getLocalidad() + ";";

                    fsSource.Write(ASCIIEncoding.ASCII.GetBytes(linea), 0, linea.Length);


                }

                fsSource.Close();
            }

        }

    }
}
