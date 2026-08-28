using System;
using DG.Tweening;
using Game.CodedAnimation;
using TMPro;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
	[SerializeField]
	private TextMeshPro textMesh;

	[SerializeField]
	private float _fadeDuration;

	[SerializeField]
	private float _delayFade;

	private Action<FloatingText> _onDisabled;

	private Tween _textTween;

	private float _fadeDurationScale;

	private FloatingTextAnimator _textAnimator;

	public int Channel { get; private set; }

	private void OnDisable()
	{
	}

	public void UpdateInfo(int channel, string content, Color color, float fontSize, float durationScale, FloatingTextAnimator textAnimator = null)
	{
	}

	public void SetDisabledCallback(Action<FloatingText> onDisabled)
	{
	}

	public void SetFade()
	{
	}
}
