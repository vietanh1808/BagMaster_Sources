using UnityEngine;
using UnityEngine.Events;

namespace Game.GUI
{
	[RequireComponent(typeof(RectTransform))]
	public class UiBehaviour : MonoBehaviour, IVisibleUi
	{
		public UnityEvent OnFirstTimeVisibleEvent;

		public UnityEvent OnBecameVisibleEvent;

		public UnityEvent OnBecameHiddenEvent;

		[field: SerializeField]
		[field: HideInInspector]
		public RectTransform RectTransform { get; private set; }

		public bool IsVisible { get; set; }

		public bool HasBeenVisible { get; protected set; }

		protected virtual void OnValidate()
		{
		}

		public virtual void OnUiBecameVisible()
		{
		}

		public virtual void OnUiBecameHidden()
		{
		}

		protected void CheckFirstTimeVisible()
		{
		}

		protected virtual void OnUiFirstTimeVisible()
		{
		}
	}
}
