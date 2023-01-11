using System;


namespace Estacionamento
{
    class Program
    {
        static void Main()
        {

            bool menu = true;
            string addVeiculo, removeVeiculo;
            int valorEntrada, valorHora, escolhaMenu, horasVeiculo;
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("     Sistema de Estacionamento      ");
            Console.WriteLine("------------------------------------");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Valor de entrada no estacionamento ");
            Console.WriteLine("------------------------------------");
            Console.Write("Resposta: ");
            valorEntrada = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" Valor cobrado por hora estacionado ");
            Console.WriteLine("------------------------------------");
            Console.Write("Resposta: ");
            valorHora = int.Parse(Console.ReadLine());

            List<string> Placas = new List<string>();


        menu:
            while (menu == true)
            {
                removeVeiculo = null;
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("                Menu                ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("      1 - Cadastrar veiculo         ");
                Console.WriteLine("       2 - Remover veiculo          ");
                Console.WriteLine("       3 - Listar veiculos          ");
                Console.WriteLine("          0 - Encerrar              ");
                Console.WriteLine("------------------------------------");
                Console.Write("    Opcao: ");
                escolhaMenu = int.Parse(Console.ReadLine());

                switch (escolhaMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("         Cadastrar veiculo          ");
                        Console.WriteLine("     Digite a placa do veiculo      ");
                        Console.WriteLine("------------------------------------");
                        Console.Write("    Resposta: ");
                        addVeiculo = Convert.ToString(Console.ReadLine());
                        Placas.Add(addVeiculo);
                        Console.Clear();
                        Console.WriteLine("    Veiculo cadastrao com sucesso!    ");
                        Console.WriteLine("Aperte em qualquer botao para continuar");
                        addVeiculo = null;
                        Console.ReadKey();
                        goto menu;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("          Remover veiculo           ");
                        Console.WriteLine("     Digite a placa do veiculo      ");
                        Console.WriteLine("------------------------------------");
                        foreach (string i in Placas)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("------------------------------------");
                        Console.Write("    Resposta: ");
                        removeVeiculo = Convert.ToString(Console.ReadLine());

                        if (Placas.Any(x => x.ToUpper() == removeVeiculo.ToUpper()))
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("             Pagamento              ");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("   Quantas horas o veiculo ficou ?  ");
                            Console.WriteLine("------------------------------------");
                            Console.Write("    Resposta: ");
                            horasVeiculo = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("             Pagamento              ");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("     Veiculo removido com sucesso   ");
                            Console.WriteLine($" e pagou R${(valorHora * horasVeiculo) + valorEntrada}. ");
                            Console.WriteLine("------------------------------------");
                            Placas.Remove(removeVeiculo);
                            Console.ReadKey();
                            goto menu;

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"O veiculo {removeVeiculo} não esta cadastrado.");
                            Console.WriteLine("Aperte qualquer tecla para continuar");
                            Console.ReadKey();
                            goto menu;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("         Lista de veiculos          ");
                        Console.WriteLine("     Digite a placa do veiculo      ");
                        Console.WriteLine("------------------------------------");
                        foreach (string a in Placas)
                        {
                            Console.WriteLine(a);
                        }
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("   Aperte em qualquer tecla para    ");
                        Console.WriteLine("        retornar ao menu            ");
                        Console.WriteLine("------------------------------------");
                        Console.ReadKey();
                        goto menu;
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Encerrando o programa...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Entrada inválida, aperte qualquer tecla");
                        Console.ReadKey();
                        goto menu;
                        break;
                }

            }

        }

    }
}