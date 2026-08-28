using UnityEngine;

public struct IntRect
{
	public int MinX;

	public int MaxX;

	public int MinY;

	public int MaxY;

	public int Width => 0;

	public int Height => 0;

	public Vector2Int Size => default;

	public IntRect(int minX, int maxX, int minY, int maxY)
	{
		MinX = 0;
		MaxX = 0;
		MinY = 0;
		MaxY = 0;
	}
}
