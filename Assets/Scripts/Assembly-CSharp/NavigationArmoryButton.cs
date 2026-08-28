using UnityEngine;
using UnityEngine.UI;

public class NavigationArmoryButton : MonoBehaviour
{
	[SerializeField]
	private Toggle _toggle;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private string _onAnimationName;

	[SerializeField]
	private string _offAnimationName;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnToggled(bool isOn)
	{
	}
}
