using Game;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class NavigationButton : UIButtonMethods
{
	public string featureName;

	public Vector3 onIconPosition;

	private void Start()
	{
	}

	private void OnToggle(bool toggleState)
	{
	}

	private void StateUpdate(bool stateValue)
	{
	}
}
