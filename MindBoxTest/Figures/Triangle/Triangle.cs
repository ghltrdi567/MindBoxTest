using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public  class Triangle : IFigure
    {
        /// <summary>
        /// Исходные данные для однозначного задания фигуры
        /// </summary>
        private readonly IFigureData _data;

        /// <summary>
        /// Возвращает площать треугольника, заданного по трём сторонам
        /// </summary>
        /// <param name="triangleData"></param>
        /// <returns></returns>
        private double GetArea(TriangleData triangleData)
        {
            if(triangleData is null)
            {
                Console.WriteLine("Не удалось вычислить площадь. Не найдет треугольник");
                return 0;
            }

            double half_perimeter = triangleData.GetPerimetr();

            return Math.Sqrt(half_perimeter * (half_perimeter - triangleData.GetFirstSide()) *
                (half_perimeter - triangleData.GetSecondSide()) * (half_perimeter - triangleData.GetThirdSide()));

        }

        public double GetArea()
        {
            //В зависимости от метода задания круга, используется соответствующая перегрузка
            if (_data is TriangleData) return GetArea(_data as TriangleData);

            return 0;
        }

        /// <summary>
        /// Создаёт треугольник по исходным данным
        /// </summary>
        /// <param name="data"></param>
        public Triangle(IFigureData data)
        {
            _data = data;
        }

        public bool IsRightTriangle()
        {
            //В зависимости от метода задания круга, используется соответствующая перегрузка
            if (_data is TriangleData) return IsRightTriangle(_data as TriangleData);

            return false;


        }

        /// <summary>
        /// Проверяет, прямоугольный ли треугольник по данным по трём сторонам
        /// </summary>
        /// <param name="triangleData"></param>
        /// <returns></returns>
        private bool IsRightTriangle(TriangleData triangleData)
        {
            double side1 = triangleData.GetFirstSide();
            double side2 = triangleData.GetSecondSide();
            double side3 = triangleData.GetThirdSide();

            double maxSide = Math.Max(side1, Math.Max(side2, side3));

            side1 = maxSide == side1 ? 0d : side1;
            side2 = maxSide == side2 ? 0d : side2;
            side3 = maxSide == side3 ? 0d : side3;

            return maxSide * maxSide == side1 * side1 + side2 * side2 + side3 * side3;


        }
    }
}
