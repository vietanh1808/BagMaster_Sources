using System;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class GearLog : MonoBehaviour
	{
		public enum Type
		{
			Damage = 0,
			Heal = 1,
			Shield = 2
		}

		[SerializeField]
		private TextMeshPro _text;

		[SerializeField]
		private float _value;

		public Action<float> OnLog;

		public float Value => 0f;

		private void Start()
		{
		}

		public void AddValue(float add)
		{
		}

		public void Log(float value, Type type)
		{
		}

		private string FormatStatValue(float value)
		{
			return null;
		}

		private void RegisterResetNextWave()
		{
		}
	}
}
