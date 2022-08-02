using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> multiplo3 = new List<int>();
                List<int> multiplo5 = new List<int>();
                Console.WriteLine("Informe um numéro natural:");
                //
                int numero = 0;
                if (!int.TryParse(Console.ReadLine(), out numero))
                    throw new Exception("Erro: numéro informado não é valido");
                int cont = 0;
                while (cont <= numero)
                {
                    if (cont % 3 == 0)
                        multiplo3.Add(cont);
                    else if (cont % 5 == 0)
                        multiplo5.Add(cont);

                    cont++;
                }
                Console.WriteLine($"Soma dos multiplos de 3 e 5 é: {(multiplo3.Sum() +  multiplo5.Sum())}");
                Console.WriteLine("pressione qualquer tecla para sair!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}
