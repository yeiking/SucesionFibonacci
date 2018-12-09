using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucesionFibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metodos Stat = new Metodos();
            int Limite;

            Console.WriteLine("Select an option: " + "\n" + "1. Whith Statement for." + "\n" + "2. Whith Recursive Method.");
            
            int opcion;
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Limite = Stat.Limite();
                    Stat.StatementFor(Limite);

                    break;

                case 2:

                    Limite = Stat.Limite();
                    Stat.RecursiveM(Limite);

                    break;

                default:
                    break;
            }

            Console.ReadKey();

        }

    }
}
