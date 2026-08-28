using UnityEngine;

namespace Game.GUI
{
	public interface IVisibleUi
	{
		RectTransform RectTransform { get; }

		bool IsVisible { get; set; }

		void OnUiBecameVisible()
		{
		}

		void OnUiBecameHidden()
		{
		}
	}
}
