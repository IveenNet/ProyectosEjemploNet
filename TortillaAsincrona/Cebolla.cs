using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAsincrona
{
    internal class Cebolla
    {

        public async Task hacerCebolla(int num)
        {

            pelarCebolla();
            freirCebolla(num);
            
        }


        private async Task pelarCebolla()
        {

            await Task.Delay(new Random().Next(1000, 5000));

        }


        private async Task freirCebolla(int num)
        {

            await Task.Delay(new Random().Next(1000, 5000));

            Console.WriteLine($"Cebolla hecha {num}");

        }

    }
}
