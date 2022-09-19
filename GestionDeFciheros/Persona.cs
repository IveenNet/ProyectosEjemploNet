using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Persona
    {

        private string _nombre;
        private int _edad;
        private string _localidad;

        public Persona(string nombre="Ivan", int edad=5, string localidad="Jose")
        {
            this._nombre = nombre;
            this._edad = edad;
            this._localidad = localidad;
        }

        public string getNombre()
        {
            return this._nombre;
        }

        public int  getEdad()
        {
            return this._edad;
        }

        public string getLocalidad()
        {
            return this._localidad;
        }

        public override string ToString()
        {

            return $"Nombre: {_nombre},  Edad: {_edad}, Localidad:{_localidad}";
        }

    }
}
