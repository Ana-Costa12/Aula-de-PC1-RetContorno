using System;

namespace Aula_de_PC1_RetContorno
{
    class Program
    {
        static void Validade()
        {
            bool LarguraValido, AlturaValido;
            int Largura, Altura;
            int valor1 =1, valor2 = 1;

            LarguraValido = int.TryParse(Console.ReadLine(), out Largura);
            if (!LarguraValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tente novamente!");
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }
            if (Largura < 1 || Largura > 10 )
            {
                Console.ForegroundColor =ConsoleColor.Red;
                Console.WriteLine("VALOR INVÁLIDO.");
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
                Console.Clear();
                Environment.Exit(-1);
            }
            else 
            {
                Console.WriteLine("Certo! Agora digite a altura: ");
                AlturaValido = int.TryParse(Console.ReadLine(), out Altura);
                if (!AlturaValido)
                { 
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Feche o programa e tente novamente.");
                   Console.ResetColor();
                   Console.WriteLine("Pressione qualquer tecla.");
                   Console.ReadKey();
                   Console.Clear();
                   Environment.Exit(-1);
                }
               if (Altura < 1 || Altura > 10)
                {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("VALOR INVÁLIDO!");
                   Console.ResetColor();
                   Console.WriteLine("Feche o programa e siga as instruçôes corretamente.\nPressione qualquer tecla.");
                   Console.ReadKey();
                   Console.Clear();
                   Environment.Exit(-1);
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                 while ( valor1 <= Altura)
                 {
                     while ( valor2 <= Largura)
                     {
                        if (valor2 == 1 || valor2 == Largura || valor1 == 1 || valor1 == Altura)
                        {
                           Console.Write("+ ");
                        }
                        else
                        {
                           Console.Write("  ");
                        }
                        valor2++;
                    }
                
                   valor2 = 1;
                   Console.WriteLine();
                   valor1++;
                }
                Console.ResetColor();
            }
        
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos desenhar um retângulo!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("####################################");
            Console.WriteLine("Por favor digite o valor da largura:");
            Console.WriteLine("####################################");
            Console.ResetColor();
            Program.Validade();         
        }
    }
}
