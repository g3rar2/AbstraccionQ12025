using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionQ12025
{
    public class Circulo : Figura
    {
        public double Radio;
        public override double Area()
        {
            double area = Math.PI * Radio * Radio;
            return area;
        }
 
        public override double Perimetro()
        {
            return 2*Math.PI;
        }
    }
}
