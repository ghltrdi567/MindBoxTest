using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    internal class Triangle : IFigure
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
        public double GetArea(TriangleData triangleData)
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
    }
}
