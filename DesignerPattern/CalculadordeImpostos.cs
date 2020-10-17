using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern
{
    public class CalculadordeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            return imposto.calcula(orcamento);
        }
    }
}
