namespace Shape;

using System;
using ShapeInterfaces;

public class Square : ITwoDimensionalShape, IManageShape
{
	public double Radius { get; set; }

	// Implementation of ITwoDimensionalShape interface
	public double Area()
	{
		// Account for null and 0 passed values in radius as the area of that square would not exist
		// Technically null or 0 values should never be allowed in a double regardless
		if ((this.Radius != 0) && (this.Radius != null)) 
		{
			return (Math.Pow((this.Radius * 2), 2));
		} 
		// Return 0 and account for a 0 result in the output function meaning the input was invalid
		return 0;	
	}

	// Implementation of IManageShape interface
	public double Calculate()
	{
		return this.Area();
	}

	public void OutputDimensions()
	{
		Console.WriteLine(this.Calculate());
	}	
}
