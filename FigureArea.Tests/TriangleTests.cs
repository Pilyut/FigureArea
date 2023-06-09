
namespace FigureArea.Tests
{
	public class TriangleTests
	{
		[Fact]
		public void TryToCreateTriangleWithIncorrectParameters()
		{
			double a = 1.2;
			double b = 1.5;
			double c = 9;

			try
			{
				new Triangle(a, b, c);
				Assert.Fail("It's not a triangle");
			}
			catch (Exception ex) { }
		}

		[Fact]
		public void CalculateTriangleAreaTest()
		{
			double a = 10;
			double b = 6;
			double c = 8;

			Triangle triangle = new(a, b, c);

			double area = triangle.GetArea();

			Assert.Equal(24,area);
		}

		[Fact]
		public void IsTraiangleAngledTest()
		{
			double a = 4;
			double b = 5;
			double c = 3;

			Triangle triangle = new(a, b, c);

			bool testResult = triangle.IsTriangleAngled();
			Assert.True(testResult);
		}

		[Fact]
		public void CalculateCircleAreaTest()
		{
			double radius = 10;
			double expected = Math.PI * Math.Pow(radius, 2);

			Circle circle = new(radius);

			double area = circle.GetArea();

			Assert.Equal(expected, area);
		}
	}
}