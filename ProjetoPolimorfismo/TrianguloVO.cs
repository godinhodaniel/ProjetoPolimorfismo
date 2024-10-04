using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Nome Completo: Daniel de Paula Godinho
Data (dd/MM/yyy): 29/09/2024
Conteúdo trabalhado: herança de objetos
*/

namespace ProjetoPolimorfismo
{
    public class TrianguloVO : FiguraVO
    {
        public double Comprimento { get; } // Propriedade somente leitura (imutável)
        public double Altura { get; } // Propriedade somente leitura (imutável)

        public TrianguloVO(int v, string descricao, double comprimento, double altura) : base(descricao)
        {
            Comprimento = comprimento; 
            Altura = altura; 
        }

        public override double CalcularArea()
        {
            return (Comprimento * Altura) / 2; 
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.Write("\nComprimento: " + Comprimento + " \nAltura: " + Altura);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            TrianguloVO outroTriangulo = (TrianguloVO)obj;
            return Comprimento == outroTriangulo.Comprimento &&
                   Altura == outroTriangulo.Altura &&
                   Descricao == outroTriangulo.Descricao;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Descricao, Comprimento, Altura); 
        }
    }
}


