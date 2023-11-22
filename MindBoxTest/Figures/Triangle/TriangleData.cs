using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    /// <summary>
    /// Исходные данные для создания треуголька (по трём сторонам)
    /// </summary>
    public class TriangleData : IFigureData
    {
        /// <summary>
        /// Стороны (в метрах)
        /// </summary>
        private double[] Sides {  get; set; }

        /// <summary>
        /// Создаёт данные для треугольниа
        /// </summary>
        /// <param name="sides">Стороны треугольника (три стороны, в метрах)</param>
        public TriangleData(double[] sides)
        {
            Sides = new double[3];

            

            //Валидируем входящие длины сторон, их должно быть ровно три и они должны быть больше нуля
            byte k = 0;
            for(int i = 0; i < sides.Length; i++)
            {
                if (k == 3) break;

                if (sides[i] > 0)
                {
                    Sides[k] = sides[i];
                    k++;
                    continue;
                }
                else Console.WriteLine("Внимание! длина стороны не может быть меньше или равна нулю");

                
            }

            if (k < 3)
            { 
                Console.WriteLine("Не удалось получить необходимое количество длин сторон! Возвращён нулевой равносторонний треугольник");
                Sides = new double[] {0d, 0d, 0d};
                return;
            };


            //Каждая сторона (большая) не может быть больше суммы двух других
            var max_side = GetMaxSide();

            double sum = 0d;
            for(int i = 0;i <3;i++) {

                sum += Sides[i] == max_side ? 0 : Sides[i];
            
            }

            if(max_side > sum)
            {
                Console.WriteLine("Каждая сторона (большая) не может быть больше суммы двух других!" +
                    " Возвращён нулевой равносторонний треугольник");
                Sides = new double[] { 0d, 0d, 0d };
                return;


            }

        }


        /// <summary>
        /// Возвращает периметр треугольника
        /// </summary>
        /// <returns></returns>
        public double GetPerimetr()
        {
            return Sides[0]+ Sides[1] + Sides[2];


        }

        /// <summary>
        /// Возвращает длину первой стоороны, м
        /// </summary>
        /// <returns></returns>
        public double GetFirstSide()
        {
            return Sides[0];

        }

        /// <summary>
        /// Возвращает длину первой стоороны, м
        /// </summary>
        /// <returns></returns>
        public double GetSecondSide()
        {
            return Sides[1];

        }

        /// <summary>
        /// Возвращает длину первой стоороны, м
        /// </summary>
        /// <returns></returns>
        public double GetThirdSide()
        {
            return Sides[2];

        }

        /// <summary>
        /// Возвращает длину большей стороны 
        /// </summary>
        /// <returns></returns>
        public double GetMaxSide()
        {

           return  Math.Max(Sides[0], Math.Max(Sides[1], Sides[2]));



        }
    }
}
