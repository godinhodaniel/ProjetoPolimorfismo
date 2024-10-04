using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.Collections.Generic;
using System.Linq;

using System;
using System.Collections.Generic;

/*
Nome Completo: Daniel de Paula Godinho
Data (dd/MM/yyy): 29/09/2024
Conteúdo trabalhado: herança de objetos
*/

namespace ProjetoPolimorfismo
{
    internal class ConjuntoFiguraVO
    {
        private int codigo;
        private string descricao;
        private List<FiguraVO> listaFigura;
        private int capacidade;

        public ConjuntoFiguraVO(int codigo, string descricao, int capacidade, List<FiguraVO> figuras)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.capacidade = capacidade;
            listaFigura = figuras;
        }

        public ConjuntoFiguraVO Adicionar(FiguraVO figura)
        {
            if (listaFigura.Count < capacidade)
            {
                listaFigura.Add(figura);
                Console.WriteLine("\nFigura foi adicionada: " + figura);
            }
            else
            {
                Console.WriteLine("\nConjunto cheio e figura não foi adicionada: " + figura);
            }
            return this; // Retorna a própria instância para permitir encadeamento
        }

        public void Listar()
        {
            Console.WriteLine($"Conjunto {descricao} (Código: {codigo}) - Total de Figuras: {listaFigura.Count}");
            foreach (var figura in listaFigura)
            {
                figura.ImprimirDados();
                string numeroFormatado = figura.CalcularArea().ToString("F2");
                Console.WriteLine("Área da figura: " + numeroFormatado);
            }
        }

        public override string ToString()
        {
            return $"ConjuntoFiguraVO{{ Código={codigo}, Descrição='{descricao}', Total de Figuras={listaFigura.Count} }}";
        }
    }
}

