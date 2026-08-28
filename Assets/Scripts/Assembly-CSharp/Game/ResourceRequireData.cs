namespace Game
{
	public class ResourceRequireData
	{
		public readonly int Id;

		public readonly int Value;

		private OwnedResourceEntity _owned;

		public OwnedResourceEntity Owned => null;

		public bool IsEnough => false;

		public ResourceRequireData(string rawData)
		{
		}

		public ResourceRequireData(int id, int number)
		{
		}

		public void Cost(string source)
		{
		}

		public ResourceRequireData Clone()
		{
			return null;
		}
	}
}
