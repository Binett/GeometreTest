using Geometri.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Shapes
{
    public class Circle : IGeometricThing
    {
        public float Radius { get; set; }
        public Circle(float radius)
        {
            Radius = radius;
        }

        public Circle()
        {

        }

        /// <summary>
        /// Calculates the Area of an circle
        /// </summary>
        /// <returns>float area</returns>
        public float Area()
        {
            if (Radius < 0) return 0;
            var calc = MathF.PI * Radius * Radius;
            return MathF.Round(calc, 2);
        }

        /// <summary>
        /// Calculates the Perimeter of a circle
        /// </summary>
        /// <returns>float Perimeter</returns>
        public float Perimeter()
        {
            if (Radius < 0) return 0;
            var calc = 2 * MathF.PI * Radius;
            return MathF.Round(calc, 2);
        }
    }
}
