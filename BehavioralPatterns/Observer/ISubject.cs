using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer
{
	public interface ISubject
	{
		public void RegisterObserver(IObserver observer);
		public void UnregisterObserver(IObserver observer);
		public void Notify(MatchResult result);
	}
}
