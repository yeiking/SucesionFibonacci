using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucesionFibonacci
{
    public class Metodos
    {
        public void Imprimir(int Limite)
        {
            int Num1 = 0;
            int Num2 = 1;
            int din = 0;

            Console.WriteLine(Num1 + "\n" + Num2);

            for (int i = 0; din < Limite; i++)
            {
                din = Num1 + Num2;
                Num1 = Num2;
                Num2 = din;
                Console.WriteLine(din);
            }
       
        }
    }
}
