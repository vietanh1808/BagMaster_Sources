using System.Collections.Generic;
using UnityEngine;

namespace Game.GUI
{
	public abstract class ItemPanel<TInput, TViewItem> : UiBehaviour where TViewItem : MonoBehaviour
	{
		[SerializeField]
		protected RectTransform ItemContainer;

		[SerializeField]
		protected TViewItem ViewItemPrefab;

		protected readonly List<TViewItem> ViewItemList;

		[field: SerializeField]
		public CanvasGroup CanvasGroup { get; private set; }

		public IReadOnlyList<TViewItem> ViewItems => null;

		public float Alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnValidate()
		{
		}

		public void Init(ICollection<TInput> inputs)
		{
		}

		protected abstract void Init(TViewItem viewItem, TInput input);

		public void ClearItems()
		{
		}
	}
}
