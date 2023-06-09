
namespace FigureArea
{
	public class Triangle : Shape
	{
		private readonly double _a;
		private readonly double _b;
		private readonly double _c;

		public Triangle(double a, double b, double c)
		{
			if (a + b > c && a + c > b && b + c > a)
			{
				_a = a;
				_b = b;
				_c = c;
			}

			else 
			{
				throw new ArgumentException("It's not a triangle");
			}
		}

		public override double GetArea()
		{
			double p = (_a + _b + _c) / 2;
			return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));	
		}

		public bool IsTriangleAngled()
		{
			double[] sides = { _a, _b, _c };
			double longestSide = sides.Max();
			double longestSidePow2 = Math.Pow(longestSide, 2);

			double smallSides = 0;

			for (int i = 0; i < sides.Length; i++)
			{
				if (sides[i] < longestSide)
				{
					smallSides += Math.Pow(sides[i], 2); 
				}
			}
			
			if (longestSidePow2 != smallSides)  
				return false;
			
			return true;
		}
	}
}