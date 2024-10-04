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
    public class PontoVO
    {
        public string Descricao { get; } 
        public int X { get; } 
        public int Y { get; } 

        public PontoVO(string descricao = "p", int x = 5, int y = 5)
        {
            Descricao = descricao;
            X = x; 
            Y = y; 
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            PontoVO outroPonto = (PontoVO)obj;
            return X == outroPonto.X &&
                   Y == outroPonto.Y &&
                   Descricao == outroPonto.Descricao; 
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Descricao, X, Y); 
        }

        public override string ToString()
        {
            return $"Ponto{{ descricao={Descricao}, x={X}, y={Y} }}";
        }
    }
}

