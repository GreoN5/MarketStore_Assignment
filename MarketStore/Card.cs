namespace MarketStore
{
	public class Card
	{
		public decimal DiscountRate { get; private set; }
		public decimal CurrentPurchaseValue { get; private set; }
		public decimal TurnOverPreviousMonth { get; private set; }
		public CardTypes CardType { get; private set; }

		public Card(decimal currentPurchaseValue, decimal turnOver, CardTypes cardType) 
		{
			this.CurrentPurchaseValue = currentPurchaseValue;
			this.TurnOverPreviousMonth = turnOver;
			this.CardType = cardType;

			this.DiscountRate = DetermineDiscountDependingOnCard();
		}

		public decimal CalculateDiscount()
		{
			return (this.DiscountRate * this.CurrentPurchaseValue) / 100; // returns the result of the formula for the discount 
		}

		public decimal CalculateTotalPriceAfterDiscount()
		{
			decimal discount = CalculateDiscount(); // gets the discount from the calculation method and returns it

			return this.CurrentPurchaseValue - discount;
		}

		private decimal DetermineDiscountDependingOnCard()
		{
			decimal discountRate = 0;

			// checks for the type of card and sets the discount depending on the turnover for the previous month
			if (this.CardType == CardTypes.Bronze)
			{
				if (this.TurnOverPreviousMonth < 100)
					discountRate = 0.0m;
				else if (this.TurnOverPreviousMonth >= 100 && this.TurnOverPreviousMonth <= 300)
					discountRate = 1.0m;
				else
					discountRate = 2.5m;

				return discountRate;
			}
			else if (this.CardType == CardTypes.Silver)
			{
				if (this.TurnOverPreviousMonth < 300)
					discountRate = 2.0m;
				else
					discountRate = 3.5m;

				return discountRate;
			}
			else if (this.CardType == CardTypes.Gold)
			{
				discountRate = 2.0m;

				for (int i = 0; i < this.TurnOverPreviousMonth/100; i++)
				{
					if (discountRate < 10.0m)
						discountRate++;
					else
						return discountRate;
				}

				return discountRate;
			}

			return default;
		}
	}
}
