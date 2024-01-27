using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace petShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Seja bem-vindo ao pet shop LalaDog! Vamos começar ");

            int menu = 0;
            while (menu != 4)
            {
                if (menu == 0)
                {
                    Console.WriteLine("Escolha uma das opções ");
                    Console.WriteLine("1 - Cálculo de medicação ");
                    Console.WriteLine("2 - Agendamento de banho ");
                    Console.WriteLine("3 - Cálculo da quantidade de ração ");
                    Console.WriteLine("4 - Sair");
                }
                
                if (menu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1 - Cálculo de medicação ");
                    string medicamento;
                    Console.WriteLine("Informe o Medicamento: ");
                    medicamento= Console.ReadLine();
                    decimal peso;
                    Console.WriteLine("QUal o peso do seu pet? ");
                    peso = decimal.Parse(Console.ReadLine());
                    decimal doseKg;
                    Console.WriteLine("Qual a dose/kg? ");
                    doseKg = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"A dose total de {medicamento} é = {peso * doseKg}");
                    Console.WriteLine("Digite 0 para retornar ao menu ou 4 para sair ");
                }
                if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("2 - Agendamento de banho ");
                    string porte;
                    Console.WriteLine("Informe o porte do seu pet (pequeno, médio ou grande) ");
                    porte = Console.ReadLine();
                    decimal valorBanho = 0;
                    if (porte == "pequeno")
                    {
                        valorBanho = 80;
                    }
                    else if (porte == "médio")
                    {
                        valorBanho = 100;
                    }
                    else
                    {
                        valorBanho = 120;
                    }

                    string extra;
                    Console.WriteLine("Temos algumas opções de cuidados extras para o bem estar do seu pet ");
                    Console.WriteLine("Deseja adicionar cuidados extras?: ");
                    extra = (Console.ReadLine());
                    if (extra == "sim")
                    {
                        Console.WriteLine("Tirar pelos?");
                        string tirarPelos= Console.ReadLine();
                        if (tirarPelos == "sim")
                        {
                            valorBanho = valorBanho+20;
                        }
                        Console.WriteLine("Shampoo premium?");
                        string shampooPremium = Console.ReadLine();
                        if (shampooPremium == "sim")
                        {
                            valorBanho = (valorBanho + 20);
                        }
                        Console.WriteLine("Remover parasitas?");
                        string removerParasitas = Console.ReadLine();
                        if (removerParasitas == "sim")
                        {
                            valorBanho = (valorBanho + 20);
                            Console.WriteLine($"O valor do banho é de R$ {valorBanho}");
                            Console.WriteLine("Digite 0 para retornar ao menu ou 4 para sair ");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"O valor do banho é de R$ {valorBanho}");
                        Console.WriteLine("Digite 0 para retornar ao menu ou 4 para sair ");
                    }
                }
                if (menu == 3)
                {
                    Console.Clear();
                    Console.WriteLine("3 - Cálculo da quantidade de ração ");
                    int numeroPets;
                    Console.WriteLine("Informe a quantidade de pets que você tem: ");
                    numeroPets = int.Parse(Console.ReadLine());
                    double kgRacao;
                    Console.WriteLine("Informe quantos kg's de ração você possui: ");
                    kgRacao = double.Parse(Console.ReadLine());
                    double resultado;
                    resultado = numeroPets * 0.1 * 30;
                    Console.WriteLine($"Para um período de 30 dias você precisa de {resultado} kg de ração");
                    if (kgRacao < resultado)
                    {
                        Console.WriteLine($"Você precisa comprar {resultado - kgRacao} kg de ração");
                    }
                    else
                        Console.WriteLine("A quantidade de ração que você possui é suficiente para mais de um mês ");
                        Console.WriteLine("Digite 0 para retornar ao menu ou 4 para sair ");
                }
                
                bool deuCerto = int.TryParse(Console.ReadLine(), out menu);
                if (!deuCerto)
                {
                    Console.WriteLine("Operação inválida!");
                    Console.WriteLine("Digite um número de 1 a 4 ");

                    Thread.Sleep(1000);
                    menu = 0;
                    Console.Clear();
                }
                Console.Clear();




            }


        }
    }
}
