using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class NarractiveConversation : MonoBehaviour
{
	[Serializable]
	public class PositionSet
	{
		public string PositionName;

		public CharacterUi[] CharacterUis;

		public LinePresenter LinePresenter;
	}

	[Serializable]
	public class CharacterUi
	{
		public Image Portrait;

		public Image NamePanel;

		public TextMeshProUGUI NameText;

		[Header("Runtime")]
		public CharacterState CurrentState;
	}

	public enum CharacterState
	{
		None = 0,
		Active = 1,
		Listener = 2
	}

	[SerializeField]
	private PositionSet[] _positionSets;

	[SerializeField]
	private Sprite[] _portraits;

	[SerializeField]
	private Color _listenColor;

	[Header("Runtime")]
	[SerializeField]
	private CharacterUi[] _characterUis;

	public float ActiveScale;

	public LinePresenter _linePresenter;

	private int _linePresenterTextSpeedBase;

	private float _linePresenterDelayAdvanceBase;

	private void Awake()
	{
	}

	public void OnDialogueLocationSet(string localtion)
	{
	}

	[YarnCommand("type")]
	public void SetType(int type)
	{
	}

	[YarnCommand("set_active")]
	public void SetActive(int character, bool active)
	{
	}

	[YarnCommand("set_name")]
	public void SetName(int character, string value)
	{
	}

	[YarnCommand("c1_portrait")]
	public void C1Portrait(string portraitName)
	{
	}

	[YarnCommand("c2_portrait")]
	public void C2Portrait(string portraitName)
	{
	}

	[YarnCommand("text_speed")]
	public void SetTextSpeed(float scale)
	{
	}

	[YarnCommand("text_type_enable")]
	public void SetTextTypeEffectEnable(bool enable)
	{
	}

	[YarnCommand("delay_advance")]
	public void SetDelayAdvance(float scale)
	{
	}

	[YarnCommand("talker")]
	public void SetTalker(int talker)
	{
	}

	private Sprite GetPortrait(string portraitName)
	{
		return null;
	}

	public void SetCharacterActive(CharacterUi characterUi, CharacterState state)
	{
	}

	[YarnCommand("log")]
	public static void Log(string message)
	{
	}
}
