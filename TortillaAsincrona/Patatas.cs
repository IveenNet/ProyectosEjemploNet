using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAsincrona
{
    internal class Patatas
    {

        public async Task hacerPatata(int num)
        {

            pelarPatata();
            freirPatata(num);

        }


        private async Task pelarPatata()
        {

            await Task.Delay(new Random().Next(1000, 10000));

        }


        private async Task freirPatata(int num)
        {

            await Task.Delay(new Random().Next(1000, 10000));

            Console.WriteLine($"Patata hecha {num}");
        }

    }
}
