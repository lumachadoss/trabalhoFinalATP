using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhofinalATP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float contac, contap, contacce, chequespecial, soma, subtraçao, rendimento, juros;
            int operacao, cont = 0, contaescolhida, tranfentrecontas;


            Console.Write("Disponibilize o valor de saldo de cada uma das contas citadas:");

            Console.Write("\n\nConta corrente: ");
            contac = float.Parse(Console.ReadLine());
            Console.Write("\n\nConta corrente com que especial: ");
            contap = float.Parse(Console.ReadLine()); ;
            Console.Write("\n\nConta poupança: ");
            contacce = float.Parse(Console.ReadLine());
            Console.Write("\n\nCheque especial: ");
            chequespecial = float.Parse(Console.ReadLine());

            Console.Write("\n\nInforme o rendimento da poupança em casa decimal: ");
            rendimento = float.Parse(Console.ReadLine());
            Console.Write("\n\nInforme o juros do cheque especial em casa decimal: ");
            juros = float.Parse(Console.ReadLine());

            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("Defina a operação desejada através do seu número: ");
                Console.WriteLine(" 1 - Para Saque");
                Console.WriteLine(" 2 - Para Depósito");
                Console.WriteLine(" 3 - Para Transferência");
                Console.WriteLine(" 4 - Para Pagar Boleto");
                Console.WriteLine(" 5 - Para Consultar Saldo");
                Console.WriteLine(" 6 -Caso já tenha realizado a operação desejada e queira encerrar.");

                Console.Write("\nOperação: ");
                operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.Clear();
                    Console.Write("Qual valor deseja sacar? ");
                    subtraçao = float.Parse(Console.ReadLine());

                    Console.WriteLine("\nEm qual conta deseja realizar a operação? ");
                    Console.WriteLine(" 1 - Conta corrente");
                    Console.WriteLine(" 2 - Conta poupança");
                    Console.WriteLine(" 3 - Conta corrente com cheque especial");

                    contaescolhida = int.Parse(Console.ReadLine());

                    if (contaescolhida == 1)
                    {
                        if (subtraçao > contac)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                            contac = contac - subtraçao;
                    }
                    else if (contaescolhida == 2)
                    {
                        if (subtraçao > contap)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                            contap = contap - subtraçao;
                    }
                    else if (contaescolhida == 3)
                    {
                        if (subtraçao > (contacce + chequespecial))
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else if (subtraçao <= contacce)
                            contacce = contacce - subtraçao;

                        else if (subtraçao <= (contacce + chequespecial))
                        {
                            contacce = contacce - subtraçao;
                        }

                    }
                    cont++;

                }
                if (operacao == 2)
                {
                    cont++;
                    Console.Clear();
                    Console.WriteLine("Qual valor deseja depositar? ");
                    soma = float.Parse(Console.ReadLine());

                    Console.WriteLine("Em qual conta deseja realizar a operação? ");
                    Console.WriteLine(" 1 - Conta corrente");
                    Console.WriteLine(" 2 - Conta poupança");
                    Console.WriteLine(" 3 - Conta corrente com cheque especial");

                    contaescolhida = int.Parse(Console.ReadLine());
                    if (contaescolhida == 1)
                    {
                        contac = contac + soma;
                    }
                    else if (contaescolhida == 2)
                    {
                        contap = contap + soma;
                    }
                    else if (contaescolhida == 3)
                    {
                        contacce = contacce + soma;
                    }
                }
                if (operacao == 3)
                {
                    cont++;
                    Console.Clear();
                    Console.Write("Qual valor deseja transferir? ");
                    subtraçao = float.Parse(Console.ReadLine());

                    Console.WriteLine("\nEm qual conta deseja realizar a operação? ");
                    Console.WriteLine(" 1 - Conta corrente");
                    Console.WriteLine(" 2 - Conta poupança");
                    Console.WriteLine(" 3 - Conta corrente com cheque especial");

                    contaescolhida = int.Parse(Console.ReadLine());

                    if (contaescolhida == 1)
                    {
                        if (subtraçao > contac)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                            contac = contac - subtraçao;
                    }
                    else if (contaescolhida == 2)
                    {
                        if (subtraçao > contap)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                            contap = contap - subtraçao;
                    }
                    else if (contaescolhida == 3)
                    {
                        if (subtraçao > (contacce + chequespecial))
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else if (subtraçao <= contacce)
                            contacce = contacce - subtraçao;

                        else if (subtraçao <= (contacce + chequespecial))
                        {
                            contacce = contacce - subtraçao;
                        }

                    }
                    Console.Write("\nA tranferência é entre contas de mesmo titular? Responda: 1 - Para SIM, 2 - Para NÃO.");
                    tranfentrecontas = int.Parse(Console.ReadLine());
                    if (tranfentrecontas == 1)
                    {


                        Console.WriteLine("\nPara qual conta de mesmo titular deseja transferir o valor em questão? ");
                        Console.WriteLine(" 1 - Conta corrente");
                        Console.WriteLine(" 2 - Conta poupança");
                        Console.WriteLine(" 3 - Conta corrente com cheque especial");

                        contaescolhida = int.Parse(Console.ReadLine());
                        soma = subtraçao;
                        if (contaescolhida == 1)
                        {
                            contac = contac + soma;
                        }
                        else if (contaescolhida == 2)
                        {
                            contap = contap + soma;
                        }
                        else if (contaescolhida == 3)
                        {
                            contacce = contacce + soma;
                        }
                    }

                }
                if (operacao == 4)
                {
                    cont++;
                    Console.Clear();
                    Console.Write("Qual valor da conta que deseja pagar? ");
                    subtraçao = float.Parse(Console.ReadLine());

                    Console.WriteLine("\nEm qual conta deseja realizar a operação? ");
                    Console.WriteLine(" 1 - Conta corrente");
                    Console.WriteLine(" 2 - Conta poupança");
                    Console.WriteLine(" 3 - Conta corrente com cheque especial");

                    contaescolhida = int.Parse(Console.ReadLine());

                    if (contaescolhida == 1)
                    {
                        if (subtraçao > contac)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                            contac = contac - subtraçao;
                    }
                    else if (contaescolhida == 2)
                    {
                        if (subtraçao > contap)
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else
                            contap = contap - subtraçao;
                    }
                    else if (contaescolhida == 3)
                    {
                        if (subtraçao > (contacce + chequespecial))
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                        else if (subtraçao <= contacce)
                            contacce = contacce - subtraçao;

                        else if (subtraçao <= (contacce + chequespecial))
                        {
                            contacce = contacce - subtraçao;
                        }

                    }

                }
                if (operacao == 5)
                {
                    cont++;
                    Console.Clear();
                    Console.WriteLine("Em qual conta deseja realizar a operação? ");
                    Console.WriteLine(" 1 - Conta corrente");
                    Console.WriteLine(" 2 - Conta poupança");
                    Console.WriteLine(" 3 - Conta corrente com cheque especial");

                    contaescolhida = int.Parse(Console.ReadLine());

                    if (contaescolhida == 1)
                    {
                        Console.Write($"\nO saldo atual da conta corrente é: {contac}");
                    }
                    else if (contaescolhida == 2)
                    {
                        Console.Write($"\nO saldo atual da conta poupança é: {contap}");
                    }
                    else if (contaescolhida == 3)
                    {
                        Console.Write($"\nO saldo atual da conta poupança é: {contacce}");
                    }
                }

                if (cont == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Os valores atuais são: ");
                    Console.WriteLine($"O saldo atual da conta corrente é: {contac}");
                    Console.WriteLine($"O saldo atual da conta poupança é: {contap * (1 + rendimento)}");
                    Console.WriteLine($"O saldo atual da conta cheque especial é: {contacce * (1 - juros)}");
                    Console.WriteLine("\nPressione enter para continuar.");
                    Console.ReadKey();
                    cont = 0;
                }

            } while (operacao != 6);
            Console.ReadKey();
        }
    }
}
