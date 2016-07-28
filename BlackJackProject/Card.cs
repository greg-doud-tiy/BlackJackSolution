using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIronYard.CrashCourse.BlackJack {
	public enum Suite { Diamonds, Hearts, Clubs, Spades };
	public enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
	public class Card {
		public Suite Suite { get; set; }
		public Rank Rank { get; set; }
		public string Name { get { return $"{Rank} of {Suite}"; } }

		public Card(Suite suite, Rank rank) {
			this.Suite = suite;
			this.Rank = rank;
		}
	}
}
