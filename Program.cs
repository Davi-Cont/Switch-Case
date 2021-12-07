using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Informe a forma de Contratação" +
                                    "\n (A) Assalariado" +
                                    "\n (C) Comissionado" +
                                    "\n (H) Horista");
                string forma = Console.ReadLine().ToUpper();

                switch (forma)
                {
                    case "A":
                        Console.WriteLine("Informe o salario:");
                        double salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a porcentagem de desconto:");
                        double desc = double.Parse(Console.ReadLine());

                        salario -= salario * desc / 100;

                        Console.WriteLine("O salrio é de: " + salario.ToString("C"));
                        break;

                    case "C":
                        Console.WriteLine("Informe o valor vendido:");
                        double vendas = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a porcentagem de comissão:");
                        double comissao = double.Parse(Console.ReadLine());

                        salario = vendas * comissao / 100;

                        Console.WriteLine("A comissão pelas vendas é de : " + salario.ToString("C"));
                        break;

                    case "H":
                        Console.WriteLine("Informe a quantidade de horas:");
                        double horas = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o valor das horas:");
                        double vlr_horas = double.Parse(Console.ReadLine());

                        salario = horas * vlr_horas;

                        Console.WriteLine("O valor pelas horas trabalhadas é de: " + salario.ToString("C"));
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }

            }
            
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            finally
            {
                Console.WriteLine("Fim da execução");
            }

            
                Console.ReadKey();
        }
    }
}
