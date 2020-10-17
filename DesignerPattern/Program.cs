using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignerPattern.Impostos;

namespace DesignerPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto issretido = new ISSRetido();

            Orcamento orcamento = new Orcamento(250.00);
            CalculadordeImpostos calculador = new CalculadordeImpostos();

            Console.WriteLine($"Valor ISS: {calculador.RealizaCalculo(orcamento, iss)}");
            Console.WriteLine($"Valor ICMS: {calculador.RealizaCalculo(orcamento, icms)}");
            Console.WriteLine($"Valor ISSRetido: {calculador.RealizaCalculo(orcamento, issretido)}");

            Console.ReadKey();
        }
    }
}
