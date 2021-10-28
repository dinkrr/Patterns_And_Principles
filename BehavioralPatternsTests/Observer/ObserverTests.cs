using BehavioralPatterns.Observer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BehavioralPatternsTests.Observer
{
	[TestClass]
	public class ObserverTests
	{
		[TestMethod]
		public void ShouldNotifyObserversOfMatchResults()
		{
			//Arrange
			var subject = new MatchAggregator();
			var observer1 = new NewsPaper();
			var observer2 = new ReadioStation();
			var result = GetMatchResult();

			//Act
			subject.RegisterObserver(observer1);
			subject.RegisterObserver(observer2);
			subject.Notify(result);

			//Assert
			Assert.AreEqual(1, observer1.Results.Count);
			Assert.AreEqual(1, observer2.Results.Count);

			Assert.AreSame(result, observer1.Results[0]);	
			Assert.AreSame(result, observer2.Results[0]);	

			//Act
			subject.UnregisterObserver(observer1);
			subject.UnregisterObserver(observer2);

			//Assert
			Assert.AreEqual(0, subject.Observers.Count);
		}

		private MatchResult GetMatchResult()
		{
			return new MatchResult
			{
				WinningTeam = "IND",
				LosingTeam = "PAK"
			};
		}
	}
}
