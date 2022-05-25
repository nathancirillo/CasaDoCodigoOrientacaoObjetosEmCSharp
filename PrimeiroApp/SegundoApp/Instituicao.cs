using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoApp
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        private Departamento[] Departamentos { get; } = new Departamento[10];

        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        { 
            if(quantidadeDepartamentos < 10)
            {
                this.Departamentos[quantidadeDepartamentos++] = d; 
            }
        }

        public int ObterQuantidadeDepartamentos()
        {
            return this.quantidadeDepartamentos;
        }


        public Departamento DepartamentoPorIndice(int indice)
        {
            return Departamentos[indice];
        }


    }
}
