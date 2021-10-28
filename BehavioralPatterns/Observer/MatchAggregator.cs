using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer
{
	public class MatchAggregator : ISubject
	{
		public List<IObserver> Observers = new List<IObserver>();
		public void Notify(MatchResult result)
		{
			Observers.ForEach(observer => observer.Update(result));
		}

		public void RegisterObserver(IObserver observer)
		{
			Observers.Add(observer);	
		}

		public void UnregisterObserver(IObserver observer)
		{
			Observers.Remove(observer);
		}
	}
}
