using System.Collections.Generic;
using R3;

namespace Game.Utils.EventBroker
{
	public class EventBroker_Old
	{
		private static readonly Dictionary<string, ReactiveCommand<object>> _commands;

		public static ReactiveCommand<object> On(CommandKey key)
		{
			return null;
		}

		public static void Emit(CommandKey key, object package = null)
		{
		}

		private void AssignTemplate()
		{
		}

		private void TriggerTemplate()
		{
		}
	}
}
