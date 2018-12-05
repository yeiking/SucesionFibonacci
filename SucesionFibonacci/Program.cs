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
            Console.WriteLine("Escribe el limite de la Sucesion:");
            int Limite;
            Limite = int.Parse(Console.ReadLine());
            Metodos ins = new Metodos();
            ins.Imprimir(Limite);

            Console.ReadKey();

        }

    }
}
