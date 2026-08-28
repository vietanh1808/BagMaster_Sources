using UnityEngine;
using UnityEngine.Events;

public class AnimatedButton : MonoBehaviour
{
	public UnityEventCondition Condition;

	public UnityEvent Success;

	public UnityEvent Failure;

	public bool Interactable;

	private void Awake()
	{
	}

	public void Click()
	{
	}

	public void DoSuccess()
	{
	}

	public void DoFailure()
	{
	}
}
