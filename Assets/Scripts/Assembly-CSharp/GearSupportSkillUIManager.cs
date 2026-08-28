using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

public class GearSupportSkillUIManager : MonoBehaviour
{
	[SerializeField]
	private List<SupportSkillSlot> _supportSkillSlots;

	[SerializeField]
	private int _defaultSlotOnUi;

	public static GearSupportSkillUIManager Instance { get; private set; }

	private void Awake()
	{
	}

	public void RefreshList()
	{
	}

	private SupportSkillSlot GetSlot(int i)
	{
		return null;
	}
}
