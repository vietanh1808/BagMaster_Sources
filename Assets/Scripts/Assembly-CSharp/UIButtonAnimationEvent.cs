using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UIButtonAnimationEvent : MonoBehaviour
{
	public UnityEvent Success;

	public UnityEvent Failure;

	public UnityEvent OnStartAnimation;

	private Button _button;

	private bool _inAnimation;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void DoSuccess()
	{
	}

	public void DoFailure()
	{
	}
}
