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
    public abstract class FiguraVO
    {
        public int Codigo { get; } 
        public string Descricao { get; } 
        public PontoVO Ancora { get; } 

        protected FiguraVO(int codigo, string descricao, PontoVO ancora)
        {
            Codigo = codigo; // Atribuição no construtor
            Descricao = descricao; 
            Ancora = ancora ?? new PontoVO(); 
        }

        protected FiguraVO(string descricao)
        {
            Descricao = descricao;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            FiguraVO outraFigura = (FiguraVO)obj;
            return Codigo == outraFigura.Codigo &&
                   Descricao == outraFigura.Descricao &&
                   Ancora.Equals(outraFigura.Ancora); // Compara o ponto
        }

        // Sobrescrevendo GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(Codigo, Descricao, Ancora); 
        }

        public virtual double CalcularArea()
        {
            return 0; // Método virtual que pode ser sobrescrito
        }

        public virtual void ImprimirDados()
        {
            Console.Write($"\n\nCódigo: {Codigo}, \tdescrição: {Descricao}, \tancora: {Ancora}");
        }

        public override string ToString()
        {
            return $"Figura{{ Código={Codigo}, Descricao={Descricao} }}";
        }

        internal void imprimirDados()
        {
            throw new NotImplementedException();
        }

        internal object calcularArea()
        {
            throw new NotImplementedException();
        }

        internal object getCodigo()
        {
            throw new NotImplementedException();
        }
    }
}

