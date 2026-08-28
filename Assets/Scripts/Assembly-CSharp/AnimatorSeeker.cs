using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorSeeker : MonoBehaviour
{
	[Tooltip("Tên state trong Animator mà mày muốn nhảy tới")]
	public string stateName;

	[Tooltip("Layer index, thường mặc định là 0")]
	public int layer;

	private Animator animator;

	private void Awake()
	{
	}

	public void SeekNormalized(float normalizedTime)
	{
	}

	public void SeekSeconds(float seconds)
	{
	}

	private AnimationClip FindClipByName(string clipName)
	{
		return null;
	}
}
