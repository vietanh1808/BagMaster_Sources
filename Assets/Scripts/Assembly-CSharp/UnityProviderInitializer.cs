using System;
using UnityEngine;

public static class UnityProviderInitializer
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void SetDefaultObservableSystem()
	{
	}

	public static void SetDefaultObservableSystem(Action<Exception> unhandledExceptionHandler)
	{
	}
}
