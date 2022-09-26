using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAsincrona
{
    internal class Huevos
    {

        public async Task batirHuevos()
        {

            await Task.Delay(new Random().Next(5000, 10000));

            Console.WriteLine("Huevos batidos");

        }
    }
}
