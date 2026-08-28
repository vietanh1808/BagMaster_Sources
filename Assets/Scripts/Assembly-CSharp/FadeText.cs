using MoreMountains.Tools;
using TMPro;
using UnityEngine;

public class FadeText : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro textMesh;

	[SerializeField]
	private float _fadeDuration;

	private float _startFadeTime;

	private bool _fading;

	private MMTweenType _fadeTween;

	private void Update()
	{
	}

	public void Fade()
	{
	}
}
