using MindBoxTest;

double circle_rad = 10d;

double[] triange_sides = new double[] { 1d, 2d, 3d };

//Создаётся круг радиуса 56 (метров)


var cirle = new MindBoxTest.Circle(new MindBoxTest.CircleData(circle_rad));

var circleArea = cirle.GetArea();

var triangle = new MindBoxTest.Triangle(new MindBoxTest.TriangleData(triange_sides));

var triangleArea = triangle.GetArea();

Console.WriteLine("Площадь круга, радиуса {0} равна {1}", circle_rad, circleArea);
Console.WriteLine("Площадь треугольника , со сторонами {0}, {1} и {2} равна {3}", triange_sides[0], triange_sides[1], triange_sides[2], triangleArea);





