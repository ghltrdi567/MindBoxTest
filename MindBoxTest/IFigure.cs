using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    /// <summary>
    /// Интерфейс фигуры, предоставляющий возсожность вычислять его площадь
    /// </summary>
    public interface IFigure
    {


        /// <summary>
        /// Метод, возвращающий площадь фигуры на плоскости
        /// </summary>
        /// <returns>Площадь, кв.м</returns>
        public abstract double GetArea();



    }
}
