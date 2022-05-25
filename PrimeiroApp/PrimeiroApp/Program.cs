using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Instituicao instituicao = new Instituicao();
            Console.Write("Informe o nome da instituição: ");
            instituicao.Nome = Console.ReadLine();
            Console.Write("Informe o endereço da instituição: ");
            instituicao.Endereco = Console.ReadLine();
            Console.WriteLine($"Obrigado por informar a instituição: {instituicao.Nome}");
            Console.WriteLine($"Obrigado por informar o endereço: {instituicao.Endereco}");
            Console.Write("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
