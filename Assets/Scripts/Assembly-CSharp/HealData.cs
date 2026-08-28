public struct HealData
{
	public enum Method
	{
		Flat = 0,
		Percent = 1
	}

	public object Source;

	public float Value;

	public Method Type;

	public float FloatingTextScale;
}
