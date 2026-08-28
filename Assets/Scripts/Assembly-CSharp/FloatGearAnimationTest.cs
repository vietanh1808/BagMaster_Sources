using Game.Combat;
using UnityEngine;

public class FloatGearAnimationTest : MonoBehaviour
{
	[SerializeField]
	private FloatGearAnimator _animator;

	[SerializeField]
	private Transform _target;

	[Header("Speed")]
	[SerializeField]
	private float _timeScale;

	[Header("Slash Parameters")]
	[SerializeField]
	private float _slashUpRadius;

	[SerializeField]
	private float _slashDownRadius;

	[SerializeField]
	private float _aoeScale;

	private void PlayRecoil()
	{
	}

	private void PlaySlash()
	{
	}

	private void PlayThrust()
	{
	}

	public void Log(string message)
	{
	}
}
