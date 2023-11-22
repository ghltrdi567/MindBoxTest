using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBoxTest;

namespace MindDoxTest.Tests.CircleTests
{
    internal class CircleDataTests
    {
        [Test]
        public void CircleData_CircleData_ReturnsZeroRadius()
        {

            double r = 0;


            var circle_d = new MindBoxTest.CircleData(r);
           

            Assert.AreEqual(0d, circle_d.GetRadius(), 0, "Круг с нулевым радиусом должен иметь нулевой радиус");


        }


        [Test]
        public void CircleData_CircleData_ReturnsPlusRadius()
        {

            double r = 13;


            var circle_d = new MindBoxTest.CircleData(r);


            Assert.AreEqual(13d, circle_d.GetRadius(), 0, "Круг с положительным радиусом должен иметь такой же радиус");


        }

        [Test]
        public void CircleData_CircleData_ReturnsMinusRadius()
        {

            double r = -3;


            var circle_d = new MindBoxTest.CircleData(r);


            Assert.AreEqual(0d, circle_d.GetRadius(), 0, "Круг с отрицательным радиусом должен возвращать нулевой радиус");


        }



    }
}
