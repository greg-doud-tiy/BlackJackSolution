using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIronYard.CrashCourse.BlackJack {
	class Program {
		string[] instructions = new string[] {
			"Blackjack - Instructions",
			"A card game where the player plays against the 'house'.",
			"Each player gets two cards from a deck of from one to six card decks.",
			"Both player cards are dealt face up while the 'house' has one card face up",
			"and the other card face down.",
			""
		};
		void run() {
			HowToPlay();
			var playAgain = true;
			while(playAgain) {

				PlayABlackjackHand();

				playAgain = AskToPlayAgain();
			}
		}

		private void HowToPlay() {
			foreach(var s in instructions) {
				Prompt(s);
			}
		}

		private void PlayABlackjackHand() {
			Deck deck = new Deck();
			deck.Shuffle(7);
		}

		private bool AskToPlayAgain() {
			Prompt("Play again? (y/N) : ");
			var response = Console.ReadKey().KeyChar;
			return response.ToString().ToUpper() == "Y";
		}

		private void Prompt(string v) {
			Console.WriteLine();
			Console.Write(v);
			System.Diagnostics.Debug.WriteLine("");
			System.Diagnostics.Debug.Write(v);
		}

		static void Main(string[] args) {
			(new Program()).run();
		}
	}
}
