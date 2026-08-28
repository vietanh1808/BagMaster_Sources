using System;
using UnityEngine;

namespace Game.Combat
{
	[AddComponentMenu(null)]
	public class MonsterModelSpineTriggerEvent : MonoBehaviour
	{
		public Action OnTriggerEvent;

		public void TriggerEvent()
		{
		}
	}
}
