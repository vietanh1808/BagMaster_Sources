public interface IHasWeight
{
	int Weight { get; }
}
public interface IHasWeight<T>
{
	T Value { get; }

	float Weight { get; }
}
