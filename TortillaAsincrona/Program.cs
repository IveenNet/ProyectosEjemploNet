// See https://aka.ms/new-console-template for more information

using ProgramacionAsincrona;
using static System.Console;

//Variables

public class Program
{

    private static async Task Main(string[] args)
    {

        WriteLine("Vamos a preparar una tortilla de patatas");

        List<Task> listTask = new List<Task>();

        List<Patatas> listPatatas = new List<Patatas>();
        List<Cebolla> listCebolla = new List<Cebolla>();
        Huevos huevos = new Huevos();

        Tortilla tortilla = new Tortilla();

        for (int i = 0; i < new Random().Next(2,5); i++)
        {

            listPatatas.Add(new Patatas());

            listTask.Add(listPatatas[i].hacerPatata(i));

        }

        for (int i = 0; i < new Random().Next(2, 5); i++)
        {

            listCebolla.Add(new Cebolla());

            listTask.Add(listCebolla[i].hacerCebolla(i));

        }


        listTask.Add(huevos.batirHuevos());

        while (listTask.Any())
        {
            Task finished = await Task.WhenAny(listTask);

            listTask.Remove(finished);

        }

        tortilla.hacerTortilla(listPatatas, listCebolla, huevos);

        Console.ReadLine();

    }

}

