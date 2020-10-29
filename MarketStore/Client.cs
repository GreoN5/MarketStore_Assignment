namespace MarketStore
{
	public class Client
	{
		private string _firstName;
		private string _lastName;

		public string FullName 
		{ 
			get 
			{ 
				return $"{this._firstName} {this._lastName}";
			} 
		}

		public Card Card { get; private set; }

		public Client(string firstName, string lastName)
		{
			this._firstName = firstName;
			this._lastName = lastName;
		}

		public Client(string firstName, string lastName, Card card)
		{
			this._firstName = firstName;
			this._lastName = lastName;
			this.Card = card;
		}

		public void AddCard(Card card)
		{
			if (this.Card == null)
				this.Card = card;

			return;
		}
	}
}
