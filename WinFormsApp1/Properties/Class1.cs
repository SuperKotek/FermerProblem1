
using System.Reflection.Metadata;

namespace Задача.Фермера.Библиотека
{
    public static class Farmer
    {
        /// <summary>
        /// для треугольника по периметру 
        /// вычисляется площадь
        /// </summary>
        /// <param name="perimetr">периметр</param>
        /// <returns>площадь треугольника</returns>
        public static double Triangle(double perimetr)
        {
            return (((Math.Sqrt(3)) / 36) * Math.Pow(perimetr, 2));
        }

        /// <summary>
        /// для квадрата по периметру 
        /// вычисляется площадь
        /// </summary>
        /// <param name="perimetr">периметр</param>
        /// <returns>площадь квадрата</returns>
        public static double Quadrat(double perimetr)
        {
            return ((Math.Pow(perimetr, 2)) / 16);
        }

        /// <summary>
        /// для круга по периметру 
        /// вычисляется площадь
        /// </summary>
        /// <param name="perimetr">периметр</param>
        /// <returns>площадь круга</returns>
        public static double Circle(double perimetr)
        {
            return ((Math.Pow(perimetr, 2)) / (4 * Math.PI));
        }

        /// <summary>
        /// для ромба по периметру 
        /// вычисляется площадь
        /// </summary>
        /// <param name="perimetr">периметр</param>
        /// <returns>площадь ромба</returns>
        public static double Rhomb(double perimetr)
        {
            return ((Math.Sqrt(3) * Math.Pow(perimetr, 2)) / 32);
        }

        /// <summary>
        /// для шестиугольника по периметру 
        /// вычисляется площадь
        /// </summary>
        /// <param name="perimetr">периметр</param>
        /// <returns>площадь шестиугольника</returns>
        public static double Hexagon(double perimetr)
        {
            return ((Math.Sqrt(3) * Math.Pow(perimetr, 2)) / 24);
        }

        /// <summary>
        /// для n-угольника по периметру 
        /// вычисляется площадь
        /// </summary>
        /// <param name="perimetr">периметр</param>
        /// <param name="n">кол-во углов</param>
        /// <returns>площадь n-угольника</returns>
        public static double nangel(double perimetr, int n)
        {
            return(Math.Pow(perimetr, 2)/(4*n*Math.Tan(Math.PI/n)));
        }
    }
}
