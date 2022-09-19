using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal interface IFichero
    {
        public String ReadFile();
        public void guardarPersonas(List<Persona> listPerson);
        public void cerrarFichero();
     
    }
}
