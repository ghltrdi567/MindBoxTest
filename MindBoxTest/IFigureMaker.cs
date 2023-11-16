using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    /// <summary>
    /// Интерфейс по созданию фигур фигур
    /// </summary>
    public  interface IFigureMaker
    {

        /// <summary>
        /// Создание фигуры
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public IFigure CreateFigure(IFigureData Data);


    }
}
