using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fatec = new Instituicao()
            {
                Nome = "Fatec Jundiaí",
                Endereco = new Endereco() { Rua = "Rua Fatec", Bairro = "Bairro Fatec", Numero = "Número Fatec"}
            };

            var unip = new Instituicao()
            {
                Nome = "Unip Jundiaí",
                Endereco = new Endereco() { Rua = "Rua Unip", Bairro = "Bairro Unip", Numero = "Numero Unip"}
            };

            var firstDep = new Departamento() { Nome = "Exatas" };
            var secondDep = new Departamento() { Nome = "Humanas" };
            var thirdDep = new Departamento() { Nome = "Biológicas " };

            fatec.RegistrarDepartamento(firstDep);
            fatec.RegistrarDepartamento(secondDep);
            fatec.RegistrarDepartamento(thirdDep);


            unip.RegistrarDepartamento(firstDep);
            unip.RegistrarDepartamento(secondDep);

            Console.WriteLine("Departamentos da FATEC:");
            for (var i = 0; i < fatec.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"Departamento: {fatec.DepartamentoPorIndice(i).Nome}");
            }

            Console.WriteLine("Departamentos da UNIP:");
            for (var i = 0; i < unip.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"Departamento: {unip.DepartamentoPorIndice(i).Nome}");
            }

            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
