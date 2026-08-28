using Game.Combat;

namespace Game.EventDungeon
{
	public class EventDungeonBagNewSlotManager : BagNewSlotManager
	{
		public override bool BuySlot()
		{
			return false;
		}

		public override void AddNewSlots(NewSlot newSlot)
		{
		}
	}
}
