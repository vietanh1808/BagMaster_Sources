using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Pool;

namespace Game.Combat
{
	public class TraitShopBuffManager : IBuffManager
	{
		private struct BuffGroupStatus : IEquatable<BuffGroupStatus>
		{
			public BuffPool.WeightedBuffGroup BuffGroup;

			public int Level;

			public bool IsMaxedLevel => false;

			public BuffData CurrentBuff => null;

			public float Weight => 0f;

			public bool Equals(BuffGroupStatus other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetPriorityBuffs_003Ed__10 : IEnumerable<BuffData>, IEnumerable, IEnumerator<BuffData>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private BuffData _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private BuffFilterOptions filterOptions;

			public BuffFilterOptions _003C_003E3__filterOptions;

			private int buffCount;

			public int _003C_003E3__buffCount;

			public TraitShopBuffManager _003C_003E4__this;

			private IList<int> _003CpriorityGroupIds_003E5__2;

			private int _003Climit_003E5__3;

			private int _003Ci_003E5__4;

			BuffData IEnumerator<BuffData>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetPriorityBuffs_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<BuffData> IEnumerable<BuffData>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetRandomBuffs_003Ed__9 : IEnumerable<BuffData>, IEnumerable, IEnumerator<BuffData>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private BuffData _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public TraitShopBuffManager _003C_003E4__this;

			private int buffCount;

			public int _003C_003E3__buffCount;

			private BuffFilterOptions filterOptions;

			public BuffFilterOptions _003C_003E3__filterOptions;

			private PooledObject<List<BuffGroupStatus>> _003CpooledObject_003E5__2;

			private List<BuffGroupStatus> _003CbuffList_003E5__3;

			private float _003CtotalWeight_003E5__4;

			private int _003Climit_003E5__5;

			private IEnumerator<BuffData> _003C_003E7__wrap5;

			private int _003Ci_003E5__7;

			BuffData IEnumerator<BuffData>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetRandomBuffs_003Ed__9(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<BuffData> IEnumerable<BuffData>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public readonly bool RemoveReceivedBuffs;

		private readonly Dictionary<int, BuffGroupStatus> _rolledBuffs;

		private readonly Dictionary<int, BuffGroupStatus> _availableBuffs;

		public int AvailableBuffCount => 0;

		public TraitShopBuffManager(BuffPool buffPool, bool removeReceivedBuffs = true)
		{
		}

		private void InitBuffPool(BuffPool buffPool)
		{
		}

		public void OnDoneRolling()
		{
		}

		[IteratorStateMachine(typeof(_003CGetRandomBuffs_003Ed__9))]
		public IEnumerable<BuffData> GetRandomBuffs(int buffCount, BuffFilterOptions filterOptions = default(BuffFilterOptions))
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetPriorityBuffs_003Ed__10))]
		private IEnumerable<BuffData> GetPriorityBuffs(int buffCount, BuffFilterOptions filterOptions)
		{
			return null;
		}

		private void RemoveFromPool(BuffData chosenBuff)
		{
		}

		private void Filter(List<BuffGroupStatus> list, in BuffFilterOptions filterOptions, out float totalWeight)
		{
			totalWeight = default;
		}

		public void OnChosenBuff(BuffData buff)
		{
		}
	}
}
