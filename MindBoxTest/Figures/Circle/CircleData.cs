using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    /// <summary>
    /// Исходные данные для создания треуголька (по трём сторонам)
    /// </summary>
    internal class CircleData : IFigureData
    {
        private double _radius;

        /// <summary>
        /// Создаёт данные для круга
        /// </summary>
        /// <param name="radius"></param>
        public CircleData(double radius)
        {
           
            //Валидируем входящий радиус
            if (radius < 0)
            {
                Console.WriteLine("Радиус круга не может быть меньше нуля! задан нулевой круг.");
                _radius = 0;
            }
            else _radius = radius;

            
        }

        public double GetRadius() => _radius;


        
    }
}
