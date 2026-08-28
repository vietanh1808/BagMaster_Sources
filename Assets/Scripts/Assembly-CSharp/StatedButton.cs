using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatedButton : MonoBehaviour
{
	public enum State
	{
		Default = 0,
		Disabled = 1
	}

	[Serializable]
	public struct StateConfig
	{
		public Sprite renderSprite;

		public Color renderTextColor;
	}

	public StateConfig defaultState;

	public StateConfig disabledState;

	[SerializeField]
	private Image image;

	[SerializeField]
	private TMP_Text[] texts;

	public void SwitchState(State state)
	{
	}

	private void DisplayStateConfig(StateConfig config)
	{
	}
}
