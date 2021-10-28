using System.Collections.Generic;

namespace BehavioralPatterns.Observer
{
	public class ReadioStation : IObserver
	{
		public List<MatchResult> Results { get; set; } = new List<MatchResult>();

		public void Update(MatchResult result)
		{
			Results.Add(result);
		}
	}

	public class NewsPaper : IObserver
	{
		public List<MatchResult> Results { get; set; } = new List<MatchResult>();

		public void Update(MatchResult result)
		{
			Results.Add(result);
		}
	}
}
