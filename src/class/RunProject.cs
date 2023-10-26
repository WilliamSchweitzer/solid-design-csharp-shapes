using System;
using Shape;

public static class RunProject
{
	public static void Main()
	{
		Square testSquare = new Square();
		testSquare.Radius = 5;
		testSquare.OutputDimensions();
	}
}
