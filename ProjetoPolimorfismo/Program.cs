using System;
using System.Collections.Generic;

/*
Nome Completo: Daniel de Paula Godinho
Data (dd/MM/yyy): 29/09/2024
Conteúdo trabalhado: herança de objetos
*/

namespace ProjetoPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CirculoVO c1 = new CirculoVO(1, "Círculo 1", 2);
            RetanguloVO r1 = new RetanguloVO(2, "Retângulo 1", 3, 4);
            TrianguloVO t1 = new TrianguloVO(3, "Triângulo 1", 2, 3);

            ConjuntoFiguraVO cf1 = new ConjuntoFiguraVO(1, "cf1", 5, new List<FiguraVO> { c1, r1 });

            cf1.Listar();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            cf1 = cf1.Adicionar(t1);
            cf1.Listar();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            CirculoVO c2 = new CirculoVO(4, "Círculo 2", 0.4);
            cf1 = cf1.Adicionar(c2);
            cf1.Listar();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
