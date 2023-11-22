using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDoxTest.Tests.Triangle
{
    internal class TriangleDataTests
    {

        /// <summary>
        /// Тест задания треугольника со стороной равной сумме двух других
        /// </summary>
        [Test]
        public void TriangleData_TriangleData_BiggerSide()
        {

            double[] sides = { 1d, 2d, 4d };

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == 0d && triang_d.GetSecondSide() == 0d && 
                triang_d.GetThirdSide() == 0d, "не может быть треугольник со стороной больше чем сумма двух других");
        }


        /// <summary>
        /// Тест задания треугольника со стороной равной сумме двух других
        /// </summary>
        [Test]
        public void TriangleData_TriangleData_EqualSumSide()
        {

            double[] sides = { 1d, 2d, 3d };

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == sides[0] && triang_d.GetSecondSide() == sides[1] &&
                triang_d.GetThirdSide() == sides[2], "Стороны не равны  исходным");
        }



        [Test]
        public void TriangleData_TriangleData_correctSides()
        {

            double[] sides = { 2d, 4d, 5d };

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == sides[0] && triang_d.GetSecondSide() == sides[1] &&
                triang_d.GetThirdSide() == sides[2], "Стороны не равны  исходным");
        }

        /// <summary>
        /// ТЕст задания треугольника с большим количеством сторон
        /// </summary>
        [Test]
        public void TriangleData_TriangleData_Extraside()
        {

            double[] sides = { 2d, 4d, 5d, 6d};

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == sides[0] && triang_d.GetSecondSide() == sides[1] &&
                triang_d.GetThirdSide() == sides[2], "Стороны не равны  исходным");
        }


        [Test]
        public void TriangleData_TriangleData_nullSide()
        {

            double[] sides = { 1d, 0d, 3d};

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == 0d && triang_d.GetSecondSide() == 0d &&
                triang_d.GetThirdSide() == 0d, "треугольник должен быть нулевой");
        }

        [Test]
        public void TriangleData_TriangleData_minusSide()
        {

            double[] sides = { 1d, -2d, 3d };

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == 0d && triang_d.GetSecondSide() == 0d &&
                triang_d.GetThirdSide() == 0d, "треугольник должен быть нулевой");
        }


        [Test]
        public void TriangleData_TriangleData_TwoSide()
        {

            double[] sides = { 1d, 2d};

            var triang_d = new MindBoxTest.TriangleData(sides);

            Assert.IsTrue(triang_d.GetFirstSide() == 0d && triang_d.GetSecondSide() == 0d &&
                triang_d.GetThirdSide() == 0d, "треугольник должен быть нулевой");
        }



    }
}
