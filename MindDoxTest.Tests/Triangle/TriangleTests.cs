using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDoxTest.Tests.Triangle
{
    internal class TriangleTests
    {
        /// <summary>
        /// Тест площади треугольника со стороной равной сумме друх других сторон
        /// </summary>
        [Test]
        public void Triangle_GetArea_EqualsSumSides()
        {

            double[] sides = { 1d, 2d, 3d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_area = new MindBoxTest.Triangle(triang_d).GetArea();




            Assert.AreEqual(triangle_area, 0d, 0, "площадь должна быть нулевая");

        }


        [Test]
        public void Triangle_GetArea_RightTriangleTest()
        {

            double[] sides = { 8d, 13d, 12d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_area = new MindBoxTest.Triangle(triang_d).GetArea();




            Assert.AreEqual(triangle_area, 46.999d, 1e-2, "площадь неверная");

        }

        [Test]
        public void Triangle_GetArea_ZeroTriangle()
        {

            double[] sides = { 0d, 0d, 0d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_area = new MindBoxTest.Triangle(triang_d).GetArea();




            Assert.AreEqual(triangle_area, 0d, 0d, "площадь нулевого треугольника должна быть нулевая");

        }



        [Test]
        public void Triangle_IsRight_ZeroTriangle()
        {

            double[] sides = { 0d, 0d, 0d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_is_right = new MindBoxTest.Triangle(triang_d).IsRightTriangle();




            Assert.AreEqual(triangle_is_right, false, "Нулевой треугольник должен быть непрямоугольным");

        }

        /// <summary>
        /// Тест прямоугольности треугольника со стороной , равной сумме двух других
        /// </summary>
        [Test]
        public void Triangle_IsRight_SideSumEquals()
        {

            double[] sides = { 1d, 2d, 3d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_is_right = new MindBoxTest.Triangle(triang_d).IsRightTriangle();




            Assert.AreEqual(triangle_is_right, false, "такой треугольник должен быть непрямоугольным");

        }


        [Test]
        public void Triangle_IsRight_NotRight()
        {

            double[] sides = { 8d, 13d, 12d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_is_right = new MindBoxTest.Triangle(triang_d).IsRightTriangle();




            Assert.AreEqual(triangle_is_right, false, "такой треугольник должен быть непрямоугольным");

        }


        [Test]
        public void Triangle_IsRight_Right1()
        {

            double[] sides = { 3d, 4d, 5d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_is_right = new MindBoxTest.Triangle(triang_d).IsRightTriangle();




            Assert.AreEqual(triangle_is_right, true, "такой треугольник должен быть прямоугольным");

        }

        [Test]
        public void Triangle_IsRight_Right2()
        {

            double[] sides = { 12d, 13d, 5d };
            var triang_d = new MindBoxTest.TriangleData(sides);


            var triangle_is_right = new MindBoxTest.Triangle(triang_d).IsRightTriangle();




            Assert.AreEqual(triangle_is_right, true, "такой треугольник должен быть прямоугольным");

        }





    }
}
