using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool notaValida = false;

            do
            {
                Console.WriteLine("Insira sua nota de 0 a 10!:");
                 int nota = int.Parse(Console.ReadLine());
                
                
                if (nota == 10)
                {
                    Console.WriteLine("Nota validada!");
                    notaValida = true;
                }
                if (nota < 10)
                {
                    Console.WriteLine("Nota validada!");
                    notaValida = true;
                }else {
                    Console.WriteLine("A nota inserida é invalida , por favor insira uma nota valida!");
                    nota = int.Parse(Console.ReadLine());
                    notaValida = false;
                }

            } while (notaValida == false);
        }
    }
}
