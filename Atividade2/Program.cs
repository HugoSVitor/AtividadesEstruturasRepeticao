using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaAceitavel = false;
            
           do
           {
            Console.WriteLine("Insira um nome de usuário: ");
            string nomeUsuario = Console.ReadLine().ToLower();

            Console.WriteLine("Insira uma senha: ");
            string senhaUsuario = Console.ReadLine().ToLower();

               if (senhaUsuario != nomeUsuario)
                {
                    Console.WriteLine("Nome e Senha validados!");
                    senhaAceitavel = true;
                }else
                {
                    Console.WriteLine("Senha inserida invalida!");
                    senhaAceitavel == false;
                }
           } while (senhaAceitavel == false);
           {
           }
        }
    }
}
