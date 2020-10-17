using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Impostos
{
    public class ICMS : Imposto
    {
        public double calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 1.0;
        }
    }
}
