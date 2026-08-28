using System.Collections.Generic;
using System.Collections.ObjectModel;
using R3;
using UnityEngine;

namespace Game
{
	public class Stat
	{
		public delegate bool GetValueCustomDelegate(StatModifier modifier);

		public readonly int Id;

		public readonly Sprite Icon;

		public readonly string Name;

		public readonly float CpModifier;

		public readonly float CpModifier2;

		public readonly ReadOnlyCollection<StatModifier> Modifiers;

		private bool _isDirty;

		private float _value;

		private float _baseValue;

		private float _percentAdd;

		private readonly List<StatModifier> _modifiers;

		public string NameLocalized => null;

		public float BaseValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Value => 0f;

		public int IntValue => 0;

		public Subject<float> OnValueChanged { get; }

		public Stat(Stat from)
		{
		}

		public Stat(float baseValue, int id, Sprite icon, string name, float cpModifier, float cpModifier2 = 0f)
		{
		}

		public Stat(float baseValue, float cpModifier, float cpModifier2 = 0f)
		{
		}

		public void AddModifiers(Stat source)
		{
		}

		public void AddModifier(StatModifier modifier)
		{
		}

		private int SortModifier(StatModifier m1, StatModifier m2)
		{
			return 0;
		}

		public bool RemoveModifier(StatModifier modifier)
		{
			return false;
		}

		public void RemoveAllModifiers()
		{
		}

		public bool RemoveAllModifiersFromSource(object source)
		{
			return false;
		}

		public bool HasAnyModifiersFromSource(object source)
		{
			return false;
		}

		public void CalculateValue()
		{
		}

		private void ApplyModifierToValue(StatModifier modifier, int index, ref float value, ref float percentAdd)
		{
		}

		public float GetValueCustom(GetValueCustomDelegate filter)
		{
			return 0f;
		}
	}
}
