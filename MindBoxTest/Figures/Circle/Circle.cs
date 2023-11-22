using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public  class Circle : IFigure
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
        private double GetArea(CircleData circleData)
        {
            if(circleData is null)
            {
                Console.WriteLine("Не удалось вычислить площадь. Не найден круг");
                return 0;
            }

           var radius = circleData.GetRadius();

            return Math.PI * radius * radius;
        }

        public double GetArea()
        {
            //В зависимости от метода задания круга, используется соответствующая перегрузка
            if (_data is CircleData) return GetArea(_data as CircleData);

            return 0;
        }

        /// <summary>
        /// Создаёт треугольник по исходным данным
        /// </summary>
        /// <param name="data"></param>
        public Circle(IFigureData data)
        {
            _data = data;
        }
    }
}
