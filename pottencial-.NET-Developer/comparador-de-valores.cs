/*

Desafio
Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que 
construísse um programa para verificar, à partir de dois valores muito grandes A e B,
se B corresponde aos últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um 
inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste 
de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

*/

using System;
using System.IO;
using System.Linq;

class DIO
{

    static void Main(string[] args)
    {
        string[] v = new string[2];
        int qt = int.Parse(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++)
        {
            v = Console.ReadLine().Split(" ");

            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}