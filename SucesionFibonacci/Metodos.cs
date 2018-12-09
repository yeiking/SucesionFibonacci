using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucesionFibonacci
{
    public class Metodos
    {
        int Num1 = 0;
        int Num2 = 1;
        int aux = 0;

        public void StatementFor(int Limite)
        {


            Console.WriteLine(Num1 + "\n" + Num2);

            for (int i = 0; aux < Limite; i++)
            {
                aux = Num1 + Num2;
                Num1 = Num2;
                Num2 = aux;
                Console.WriteLine(aux);
            }

        }

        public void RecursiveM(int Limite)
        {
            aux = Num1;
            Num1 = Num2; 
            Num2 = aux + Num1; 
            Console.WriteLine(aux); 

            while (aux<=Limite)
            {
                RecursiveM(Limite);
            }

        }

        public int Limite()
        {
            Console.WriteLine("Now write the limit of succession:");
            int Limite;
            Limite = int.Parse(Console.ReadLine());

            return Limite;
        }


    }
}
