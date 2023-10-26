namespace ShapeInterfaces;

public interface ITwoDimensionalShape
{
	double Area();
}

public interface IThreeDimensionalShape
{
	double SurfaceArea();

	double Volume();
}

public interface IManageShape
{
	double Calculate();

	void OutputDimensions();
}
