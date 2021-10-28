using System.Collections.Generic;

namespace BehavioralPatterns.Observer
{
	public interface IObserver
	{
		public List<MatchResult> Results { get; set; }
		public void Update(MatchResult result);
	}
}