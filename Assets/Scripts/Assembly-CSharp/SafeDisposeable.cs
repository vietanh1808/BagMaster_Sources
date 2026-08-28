using System;

public abstract class SafeDisposeable : IDisposable
{
	private bool disposed;

	protected virtual void Dispose(bool disposing)
	{
	}

	protected abstract void DoDispose();

	public void Dispose()
	{
	}

	~SafeDisposeable()
	{
	}
}
