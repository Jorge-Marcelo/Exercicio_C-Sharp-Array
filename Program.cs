using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_356
{
 internal class Program
 {
  static void Main(string[] args)
  {
   int iterador;
   int[] media = new int[5];
   string[] nomes = new string[5];
   string[] situacao = new string[5];
   double[] nota1 = new double[5];
   double[] nota2 = new double[5];

for(iterador = 0; iterador <= 4; iterador++){
Console.Write($"Digite {iterador + 1}º nome: ");
nomes[iterador] = Console.ReadLine();

Console.WriteLine("----------------------------------------------------------");

Console.Write("Digite a primeira nota: ");
nota1[iterador] = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
nota2[iterador] = double.Parse(Console.ReadLine());

media[iterador] = (int)Math.Round((nota1[iterador] + nota2[iterador]) / 2 + 0.0001);

Console.WriteLine("----------------------------------------------------------");

if (media[iterador] >= 5){ situacao[iterador] = "APROVADO!"; }
else { situacao[iterador] = "REPROVADO"; }
   }



Console.WriteLine($"Relação dos alunos");

for (iterador = 0; iterador <= 4; iterador++)
{
Console.WriteLine($"Nome: {nomes[iterador]} / Nota 1: {nota1[iterador]} / Nota 2: {nota2[iterador]} / Situação: {situacao[iterador]} ");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");

   }









  }
 }
}
