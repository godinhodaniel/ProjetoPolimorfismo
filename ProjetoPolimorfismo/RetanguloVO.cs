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
    public class RetanguloVO : FiguraVO
    {
        public double Comprimento { get; } 
        public double Altura { get; } 

        // Construtor que define os valores do objeto VO
        public RetanguloVO(int v, string descricao, double comprimento, double altura) : base(descricao)
        {
            Comprimento = comprimento; // Atribuição no construtor
            Altura = altura; 
        }

        public override double CalcularArea()
        {
            return Comprimento * Altura; // Cálculo da área
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.Write("\nComprimento: " + Comprimento + " \nAltura: " + Altura); // Imprime comprimento e altura
        }

        // Sobrescrevendo Equals para comparar com base nos valores
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            RetanguloVO outroRetangulo = (RetanguloVO)obj;
            return Comprimento == outroRetangulo.Comprimento &&
                   Altura == outroRetangulo.Altura &&
                   Descricao == outroRetangulo.Descricao;
        }

        // Sobrescrevendo GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(Descricao, Comprimento, Altura); // Gera o hash baseado nos valores
        }
    }
}

