using System.Collections.Generic;
using System.Text;
using Game.EquipmentSystem;
using UnityEngine;

namespace Game.Skin.Demo
{
	[AddComponentMenu("Game/Dev/Skin Auto-Equip Tester")]
	public class SkinAutoEquipTester : MonoBehaviour
	{
		[Header("Timing")]
		[Tooltip("Seconds between equips. ~3s gives you time to spot bugs on each skin.")]
		[SerializeField]
		private float _interval;

		[Tooltip("Start cycling automatically once PlayerInfo is ready.")]
		[SerializeField]
		private bool _autoStart;

		[Tooltip("Loop back to the first equipment after the last one.")]
		[SerializeField]
		private bool _loop;

		[Tooltip("Unequip Head/Body/Weapon/Accessory on Start so the character begins clean.")]
		[SerializeField]
		private bool _resetVisualSlotsOnStart;

		[Header("Rarities per group (GroupId)")]
		[Tooltip("Include every rarity variant of each equipment group (matched by GroupId) for ALL parts. ON = test all rarities per group so you can watch the skin change with rarity. OFF = keep only the highest rarity per group for a faster pass.")]
		[SerializeField]
		private bool _includeAllRarities;

		private PlayerInfo _player;

		private List<EquipmentData> _queue;

		private int _index;

		private float _timer;

		private bool _running;

		private bool _playerMissingLogged;

		private static readonly EquipmentPart[] VisualParts;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void Initialize()
		{
		}

		private void BuildQueue()
		{
		}

		private static List<EquipmentData> KeepOnePerGroup(List<EquipmentData> items)
		{
			return null;
		}

		private static int TypeOrder(EquipmentPart part)
		{
			return 0;
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void Step()
		{
		}

		private void EquipOne(EquipmentData data)
		{
		}

		private void UnequipAllVisualSlots()
		{
		}

		private void LogStep(EquipmentData data)
		{
		}

		private void AppendEquipped(StringBuilder sb)
		{
		}

		private void OnGUI()
		{
		}

		private string QueueLabel()
		{
			return null;
		}

		private string EquippedSummary()
		{
			return null;
		}

		private bool TryResolvePlayer(out PlayerInfo player)
		{
			player = null;
			return false;
		}
	}
}
