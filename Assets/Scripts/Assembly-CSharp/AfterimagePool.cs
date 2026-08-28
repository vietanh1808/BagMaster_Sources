using System.Collections.Generic;
using UnityEngine;

public class AfterimagePool : MonoBehaviour
{
	[Header("Pool Config")]
	[Tooltip("Số afterimage tối đa trên 1 nhân vật")]
	public int maxPerCharacter;

	[Tooltip("Số nhân vật tối đa được hỗ trợ đồng thời")]
	public int maxCharacters;

	private Material _sharedMat;

	private AfterimageItem[] _allItems;

	private int _allocHead;

	private LinkedList<AfterimageItem> _active;

	private void Awake()
	{
	}

	public void SetMaterial(Material mat)
	{
	}

	private AfterimageItem CreateItem(int index)
	{
		return null;
	}

	public AfterimageSlot RentSlot()
	{
		return null;
	}

	public void ReturnSlot(AfterimageSlot slot)
	{
	}

	public void Spawn(AfterimageSlot slot, in AfterimageData data)
	{
	}

	private void Update()
	{
	}
}
