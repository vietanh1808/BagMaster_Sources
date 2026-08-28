using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GUI
{
	[RequireComponent(typeof(Button))]
	public class ButtonWrapper : UiBehaviour
	{
		[field: SerializeField]
		public Button ButtonComponent { get; protected set; }

		protected override void OnValidate()
		{
		}

		public virtual void AddOnClickListener(UnityAction listener)
		{
		}

		public virtual void RemoveOnClickListener(UnityAction listener)
		{
		}
	}
}
