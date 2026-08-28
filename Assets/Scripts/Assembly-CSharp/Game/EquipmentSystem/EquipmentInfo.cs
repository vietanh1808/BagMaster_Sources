using System;
using System.Runtime.CompilerServices;
using Game.UI;
using UnityEngine;
using UnityEngine.Events;

namespace Game.EquipmentSystem
{
	public abstract class EquipmentInfo : MonoBehaviour, IPooledViewItem<EquipmentDisplayData>
	{
		public UnityEvent<EquipmentInfo> OnInfoUpdatedEvent;

		private PlayerInfo _playerInfo;

		private int _virtualIndex;

		[CompilerGenerated]
		private Action<EquipmentDisplayData, int> m_OnClick;

		public EquipmentData Data { get; protected set; }

		public OwnedItemEntity Owned { get; protected set; }

		public PlayerInfo PInfo => null;

		public bool IsLocalPlayer => false;

		[field: SerializeField]
		public RectTransform RectTransform { get; private set; }

		public event Action<EquipmentDisplayData, int> OnClick
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

		public void Init(EquipmentDisplayData data, int virtualIndex)
		{
		}

		public void UpdateInfo(EquipmentData data, OwnedItemEntity owned)
		{
		}

		protected void OnButtonClick()
		{
		}

		public void UpdateInfo(EquipmentInfo other)
		{
		}

		protected abstract void UpdateInfo();

		public virtual void Clear()
		{
		}

		public int GetLevel()
		{
			return 0;
		}

		public void SetPlayerInfo(PlayerInfo playerInfo)
		{
		}
	}
}
