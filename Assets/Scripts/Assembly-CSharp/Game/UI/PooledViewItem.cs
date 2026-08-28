using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.UI
{
	public class PooledViewItem<T> : MonoBehaviour, IPooledViewItem<T>
	{
		[SerializeField]
		private Button _button;

		public UnityEvent<T> OnInit;

		[CompilerGenerated]
		private Action<T, int> m_OnClick;

		[field: SerializeField]
		public RectTransform RectTransform { get; set; }

		public int VirtualIndex { get; private set; }

		public T Data { get; private set; }

		public event Action<T, int> OnClick
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

		public void Init(T data, int virtualIndex)
		{
		}

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		public void OnButtonClicked()
		{
		}
	}
}
