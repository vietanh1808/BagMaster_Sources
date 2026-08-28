using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ToggleGroup))]
public class TangentHorizontalLayout : MonoBehaviour
{
	private static float PREFERED_UNSELECTED_CHILDELEMENT_WITH;

	private static float PREFERED_SELECTED_CHILDELEMENT_WITH;

	private static float PREFERED_SCREENSCALE_WIDTH;

	[SerializeField]
	private RectOffset _padding;

	[SerializeField]
	private List<GameObject> _featureButton;

	[SerializeField]
	private float _screenToPreferedModifier;

	private ToggleGroup _toggleGroup;

	public void Start()
	{
	}

	public void RefreshLayout()
	{
	}

	private float GetButtonPositionInArray(float startingPosition, float buttonPreferedWidth)
	{
		return 0f;
	}
}
