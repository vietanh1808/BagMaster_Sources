using DoorServices;

namespace Game
{
	public interface IIapOfferView
	{
		string IapProductId { get; }

		StoreEntryMethod StoreEntryMethod { get; }
	}
}
