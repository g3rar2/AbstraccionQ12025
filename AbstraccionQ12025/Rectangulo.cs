using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionQ12025
{
    public class Rectangulo : Figura
    {
        public double Base;
        public double Altura;
        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
