using Figures;
using Figures.Figures;

IFigure rectangle = new Rectangle(7f, 4f);
float result = rectangle.CalculateSquare();
Console.WriteLine(result);

ITriangle triangle = new Triangle(3f, 4f, 5f);
result = triangle.CalculateSquare();
bool isRightTriangle = triangle.CheckRightTriangle();
Console.WriteLine(isRightTriangle);
Console.WriteLine(result);