using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomeAceitavel = false;
            bool idadeAceitavel = false;
            bool salarioAceitavel = false;
            bool estadoCivilValido = false;

            Console.WriteLine("Insira seu nome:");
            string nome = Console.ReadLine().ToLower();

            if (nome =="")
            {
                Console.WriteLine("Nome invalido!");
                
                Console.WriteLine("Insira um nome valido!");
                nome = Console.ReadLine().ToLower();
            }if (nome !="")
            {
                Console.WriteLine("Nome validado! Seu nome é: " + nome);
                nomeAceitavel = true;                  
            }
            while (nomeAceitavel == false)
                {      
            } 



            
            Console.WriteLine("Insira sua idade:");
            int idade = int.Parse(Console.ReadLine());

              if (idade > 150)
            {
                    Console.WriteLine("Idade invalido!");
                
                    Console.WriteLine("Insira uma idade valida!");
                    idade = int.Parse(Console.ReadLine());
                    idadeAceitavel = false;
                
            }if(idade < 151)
            {
                Console.WriteLine("Idade validada! Sua idade é de: " + idade);
                idadeAceitavel = true;
            }
            while (idadeAceitavel == false)
                {
            } 





            Console.WriteLine("Insira seu salário:");
            int salario = int.Parse(Console.ReadLine());

              if (salario == 0)
            {
                    Console.WriteLine("Salário invalido!");
                
                    Console.WriteLine("Insira um salário valido!");
                    salario = int.Parse(Console.ReadLine());
                    salarioAceitavel = false;           
            }if (salario != 0)
            {
                Console.WriteLine("Salário validado! Seu salário é de: " + salario);
                salarioAceitavel = true;
            }
            while (salarioAceitavel == false)
                {
            } 



            Console.WriteLine("Insira seu estado civil (s = solteiro(a)  c = casado(a) v = viuvo(a) d = divorciado(a) ):");
            string estadoCivil = Console.ReadLine().ToLower();

            if (estadoCivil == "s")
            {
                Console.WriteLine("Estado Civil validado! Você é solteiro(a)!");
                estadoCivilValido = true;
            }
            if (estadoCivil == "c")
            {
                Console.WriteLine("Estado Civil validado! Você é casado(a)!");
                estadoCivilValido = true;
            }
            if (estadoCivil == "d")
            {
                Console.WriteLine("Estado Civil validado! Você é divorciado(a)!");
                estadoCivilValido = true;
            }
            if (estadoCivil == "v")
            {
                Console.WriteLine("Estado Civil validado! Você é viuvo(a)!");
                estadoCivilValido = true;
            }else
            {
                Console.WriteLine("Estado Civil invalido!");
                
                    Console.WriteLine("Insira um Estado Civil valido!");
                    estadoCivil = Console.ReadLine();
                    estadoCivilValido = false; 
            }
            
            while (estadoCivilValido == false)
                {
            } 
        }
    }
}
