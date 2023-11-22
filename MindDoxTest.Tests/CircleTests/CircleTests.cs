using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindDoxTest.Tests.CircleTests
{
    internal class CircleTests 
    { 
    
        [Test]
        public void CircleData_GetArea_ReturnsZeroRadius()
        {

            double r = 0d;
            var circle_d = new MindBoxTest.CircleData(r);

            var circl_area = new MindBoxTest.Circle(circle_d).GetArea();

            Assert.AreEqual(0d, circl_area, 0d, "Площать нулевого круга - нуль");


        }


        [Test]
        public void CircleData_GetArea_ReturnsPlusRadius()
        {

            double r = 13d;
            var circle_d = new MindBoxTest.CircleData(r);

            var circl_area = new MindBoxTest.Circle(circle_d).GetArea();

            Assert.AreEqual(530.92915d, circl_area, 1e-4, "Площать круга не соответствет реальности");


        }


        [Test]
        public void CircleData_GetArea_ReturnsMinusRadius()
        {

            double r = -13d;
            var circle_d = new MindBoxTest.CircleData(r);

            var circl_area = new MindBoxTest.Circle(circle_d).GetArea();

            Assert.AreEqual(0d, circl_area, 0d, "Площать круга, заданного отрицательным числом - ноль");


        }




    }
}
