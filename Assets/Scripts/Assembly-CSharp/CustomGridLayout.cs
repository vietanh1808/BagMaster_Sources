using UnityEngine;

public class CustomGridLayout : MonoBehaviour
{
	[SerializeField]
	private RectOffset _padding;

	[SerializeField]
	private Vector2 _cellSize;

	[SerializeField]
	private Vector2 _spacing;

	[SerializeField]
	private int _fixedColumnCount;

	[SerializeField]
	private bool _contentVerticalFit;

	public void RefreshLayout()
	{
	}
}
