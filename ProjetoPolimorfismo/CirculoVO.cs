using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
Nome Completo: Daniel de Paula Godinho
Data (dd/MM/yyy): 29/09/2024
Conteúdo trabalhado: herança de objetos
*/

namespace ProjetoPolimorfismo
{
    public class CirculoVO : FiguraVO
    {
        public double Raio { get; } // Propriedade somente leitura (imutável)

        // Construtor que define os valores do objeto VO
        public CirculoVO(int v, string descricao, double raio) : base(descricao)
        {
            Raio = raio; // Atribuição no construtor
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2); // Cálculo da área
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.Write("\nRaio: " + Raio); // Imprime o raio
        }

        // Sobrescrevendo Equals para comparar com base nos valores
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CirculoVO outroCirculo = (CirculoVO)obj;
            return Raio == outroCirculo.Raio && Descricao == outroCirculo.Descricao;
        }

        // Sobrescrevendo GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(Descricao, Raio); // Gera o hash baseado nos valores
        }
    }
}

