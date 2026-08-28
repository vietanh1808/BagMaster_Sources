using UnityEngine;

public class SlimeMove : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup loadingProgressBarGroup;

	[SerializeField]
	private RectTransform slime;

	[SerializeField]
	private RectTransform progressBarFill;

	[SerializeField]
	private Vector2 endPosition;

	private Vector2 startPosition;

	private void Awake()
	{
	}

	public void MoveSlime(float progress)
	{
	}
}
