using System;
using UnityEngine;

namespace Game.UI
{
	public interface IPooledViewItem<T>
	{
		RectTransform RectTransform { get; }

		event Action<T, int> OnClick;

		void Init(T data, int virtualIndex);
	}
}
