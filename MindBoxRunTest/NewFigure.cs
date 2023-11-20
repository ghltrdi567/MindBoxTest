using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBoxTest;

namespace MindBoxRunTest
{

    /// <summary>
    /// Пример описания новой фигуры
    /// </summary>
    internal class NewFigure : MindBoxTest.IFigure
    {
        private readonly IFigureData _data;


        public double GetArea()
        {
            //В зависимости от способа задания фигуры используется своя перегрузка
            if (_data is NewFirureData1) return GetArea(_data as NewFirureData1);

            if (_data is NewFirureData2) return GetArea(_data as NewFirureData2);

            return 0;
        }

        private double GetArea(NewFirureData1 data)
        {
            var area = 0;

            //реализация вычисления площади фигуры по данным NewFirureData1

            return area;

        }

        private double GetArea(NewFirureData2 data)
        {
            var area = 0;

            //реализация вычисления площади фигуры по данным NewFirureData2

            return area;

        }


        public NewFigure(IFigureData data)
        {
            _data = data;
        }


    }


    /// <summary>
    /// Набор исходных данных, нужных, для описания новой фигуры (могут быть разные типы задания исходных данных)
    /// </summary>
    internal class NewFirureData1 : MindBoxTest.IFigureData
    {




    }

    /// <summary>
    /// Другой набор исходных данных, нужных, для описания новой фигуры (могут быть разные типы задания исходных данных)
    /// </summary>
    internal class NewFirureData2 : MindBoxTest.IFigureData
    {




    }
}
