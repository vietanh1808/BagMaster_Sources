using UnityEngine;

namespace DoorServices
{
	public class Logger
	{
		private readonly string _featureName;

		public Logger(string featureName)
		{
		}

		public void LogProd(string msg, LogType logType = LogType.Log)
		{
		}

		public void LogTestOnly(string msg, LogType logType = LogType.Log)
		{
		}

		private void Log(string msg, LogType logType)
		{
		}
	}
}
