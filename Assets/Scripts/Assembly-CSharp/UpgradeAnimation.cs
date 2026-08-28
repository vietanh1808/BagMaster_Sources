using DG.Tweening;
using UnityEngine;

public class UpgradeAnimation : MonoBehaviour
{
	[Header("Arrow Settings")]
	[SerializeField]
	private RectTransform[] arrows;

	[SerializeField]
	private float arrowMoveDistance;

	[SerializeField]
	private float arrowMoveDuration;

	[SerializeField]
	private float arrowFadeDuration;

	[SerializeField]
	private float arrowFadeDelayBetween;

	[Header("Strives Settings")]
	[SerializeField]
	private RectTransform strives;

	[SerializeField]
	private float strivesMoveDistance;

	[SerializeField]
	private float strivesMoveDuration;

	[SerializeField]
	private float strivesFadeInDuration;

	[SerializeField]
	private float strivesFadeOutDuration;

	[SerializeField]
	private float strivesFadeOutDelay;

	[Header("Stars Settings")]
	[SerializeField]
	private RectTransform stars;

	[SerializeField]
	private float starsMoveDistance;

	[SerializeField]
	private float starsMoveDuration;

	[SerializeField]
	private float starsFadeInDuration;

	[SerializeField]
	private float starsFadeOutDuration;

	[SerializeField]
	private float starsFadeOutDelay;

	[Header("General Delay Settings")]
	[SerializeField]
	private float startDelay;

	[SerializeField]
	private float strivesDelay;

	[SerializeField]
	private float starsDelay;

	private Sequence sequence;

	private void OnEnable()
	{
	}

	public void PlayBounceEffect()
	{
	}
}
