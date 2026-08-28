namespace DoorServices
{
	public interface IAds
	{
		string UnitId { get; set; }

		bool Available { get; }

		void Initialize();

		void Load();

		void Show();

		void Hide();
	}
}
