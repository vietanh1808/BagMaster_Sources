using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

public class SupportSkillUIManager : MonoBehaviour
{
	public class Data
	{
		public BuffData BuffData;

		public SimpleSkill ActiveSkill;

		public List<SimpleSkill> Skills;

		public int AddedTime;

		public float CompareValue => 0f;
	}

	[SerializeField]
	private List<SupportSkillSlot> _supportSkillSlots;

	private List<Data> _datas;

	private int _addTime;

	public static SupportSkillUIManager Instance { get; private set; }

	public IReadOnlyList<Data> Datas => null;

	private void Awake()
	{
	}

	public void Add(BuffData buffData, SimpleSkill simpleSkill, List<SimpleSkill> skills)
	{
	}

	public void RefreshList()
	{
	}

	private SupportSkillSlot GetSlot(int i)
	{
		return null;
	}

	private int SortData(Data a, Data b)
	{
		return 0;
	}
}
