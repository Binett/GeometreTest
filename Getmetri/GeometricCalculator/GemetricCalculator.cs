using Geometri.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricCalculator
{
    public class GemetricCalculator
    {
        /// <summary>
        /// Calculates the area of diffrent shapes
        /// </summary>
        /// <param name="things">an array of shapes</param>
        /// <returns>float area</returns>
        public float GetArea(IGeometricThing[] things)
        {
            if (things == null) return 0;

            float area = 0f;
            foreach (var geoThing in things)
            {
                area += geoThing.Area();
            }
            return MathF.Round(area, 2);
        }

        /// <summary>
        /// Calculates the Perimeter of diffrent shapes
        /// </summary>
        /// <param name="things">an array of shapes</param>
        /// <returns>float Perimeter</returns>
        public float GetPerimeter(IGeometricThing[] things)
        {
            if (things == null) return 0;

            float perimeter = 0f;
            foreach (var geoThing in things)
            {
                perimeter += geoThing.Perimeter();
            }
            return MathF.Round(perimeter, 2);
        }
    }
}
