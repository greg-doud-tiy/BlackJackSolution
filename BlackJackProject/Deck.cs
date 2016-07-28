using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIronYard.CrashCourse.BlackJack {
	public class Deck : List<Card> {
		public void Shuffle(int times = 1) {
			Random rnd = new Random(DateTime.Now.Millisecond);
			for(int idx = 0; idx < times; idx++) {
				// split the deck
				var leftDeck = GetRange(0, Count / 2);
				var rightDeck = GetRange(Count / 2, Count / 2);
				Deck newDeck = new Deck(false);
				while(leftDeck.Count > 0 || rightDeck.Count > 0) {
					if (leftDeck.Count > 0) {
						int cnt = rnd.Next(1, 3);
						cnt = cnt > leftDeck.Count ? leftDeck.Count : cnt;
						var lcards = leftDeck.GetRange(0, cnt);
						newDeck.AddRange(lcards);
						for (var idx1 = 0; idx1 < cnt; idx1++) {
							leftDeck.RemoveAt(0);
						}
					}
					if (rightDeck.Count > 0) {
						var cnt = rnd.Next(1, 3);
						cnt = cnt > rightDeck.Count ? rightDeck.Count : cnt;
						var rcards = rightDeck.GetRange(0, cnt);
						newDeck.AddRange(rcards);
						for (var idx1 = 0; idx1 < cnt; idx1++) {
							rightDeck.RemoveAt(0);
						}
					}
				}
				this.Clear();
				this.AddRange(newDeck);
			}
		}
		private void Initialize() {
			foreach(var suite in Enum.GetNames(typeof(Suite))) { 
				foreach(var rank in Enum.GetNames(typeof(Rank))) {
					var theSuite = (Suite) Enum.Parse(typeof(Suite), suite);
					var theRank = (Rank)Enum.Parse(typeof(Rank), rank);
					this.Add(new BlackJack.Card(theSuite, theRank));
				}
			}
		}
		public Deck() : this(true) {
		}
		public Deck(bool initialize = true) : base() {
			if (initialize) {
				Initialize();
			}
		}
	}
}
