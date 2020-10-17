using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Impostos
{
    class ISS : Imposto
    {
        public double calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 3.0;
        }
    }
}
