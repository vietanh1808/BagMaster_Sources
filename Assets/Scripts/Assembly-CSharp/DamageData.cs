using Game.Combat;
using UnityEngine;

public struct DamageData
{
	public object Source;

	public float Damage;

	public bool Crit;

	public bool Immune;

	public bool IsDodged;

	public Vector3 Position;

	public bool DontShowTextDamage;

	public float FloatingTextScale;

	public Elemental Elemental;

	public bool IsSelfDamage;

	public int FloatingTextChannel;

	public float ElementCounterMod;

	public bool Effective => false;
}
