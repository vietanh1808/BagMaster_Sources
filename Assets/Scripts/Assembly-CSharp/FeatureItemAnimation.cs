using System.Collections.Generic;
using DG.Tweening;
using Game.CodedAnimation;
using UnityEngine;

public class FeatureItemAnimation : MonoBehaviour
{
	[SerializeField]
	private float _initialDelay;

	[SerializeField]
	private float _fadeInDuration;

	[SerializeField]
	private float _startScale;

	[SerializeField]
	private GameObject _newText;

	[SerializeField]
	private Vector3 _defaultScale;

	[SerializeField]
	private Vector3 _defaultPosition;

	[SerializeField]
	private Vector3 _defaultRotation;

	[SerializeField]
	private Vector2 _defaultNewTextScale;

	[SerializeField]
	private EaseOrAnimationCurve _ease;

	private List<Tween> _tweens;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void TweenCleanup()
	{
	}

	public void FadeIn()
	{
	}

	public void FadeInNewText()
	{
	}

	public void SetDefault()
	{
	}

	private void AddTween(Tween tween)
	{
	}
}
