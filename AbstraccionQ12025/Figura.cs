using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraccionQ12025
{
    public abstract class Figura
    {
        /// <summary>
        /// Abstract Method that calculates the geometric area
        /// </summary>
        /// <returns>Area value</returns>
        public abstract double Area();

        /// <summary>
        /// Abstract method to calculates the perimeter
        /// </summary>
        /// <returns>Perimeter value</returns>
        public abstract double Perimetro();

        /// <summary>
        /// Print the area and perimeter values
        /// </summary>
        /// <param name="NombreFigura">Geometric Name</param>
        public void Imprimir(string NombreFigura)
        {
            Console.WriteLine($"Area de {NombreFigura}: {Area} cm2");
            Console.WriteLine($"Perimetro de {NombreFigura}: {Perimetro} cm");
        }


    }
}
