using System;

namespace I2.Loc
{
	public class Localization
	{
		public static string Get<T>(T textId) where T : struct, IConvertible
		{
			return null;
		}

		public static string Get(string key)
		{
			return null;
		}
	}
}
