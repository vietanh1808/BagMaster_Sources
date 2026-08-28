using System;
using System.Runtime.CompilerServices;
using Game.Arena;
using UnityEngine;
using UnityEngine.UI;

public class ArenaButtonMenu : MonoBehaviour
{
	[SerializeField]
	private ArenaSubTabType tabType;

	[SerializeField]
	private Button button;

	[SerializeField]
	private GameObject activeObject;

	[SerializeField]
	private GameObject inactiveObject;

	[CompilerGenerated]
	private Action<ArenaSubTabType> m_OnClick;

	public ArenaSubTabType TabType => ArenaSubTabType.ArenaTicket;

	public event Action<ArenaSubTabType> OnClick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void SetTabActive(bool active)
	{
	}
}
