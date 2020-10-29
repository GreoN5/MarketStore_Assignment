using System;

namespace MarketStore
{
	public static class CardExtensions
	{
		public static void PrintCardDetailsForClient(this Client client)
		{
			try
			{
				Console.WriteLine($"{client.FullName}" +
					$"\n \t Card type: {client.Card.CardType}" +
					$"\n \t Purchase value: ${client.Card.CurrentPurchaseValue}" +
					$"\n \t Discount rate: {client.Card.DiscountRate}%" +
					$"\n \t Discount: ${client.Card.CalculateDiscount()}" +
					$"\n \t Total: ${client.Card.CalculateTotalPriceAfterDiscount()}");

				Console.WriteLine();
			}
			catch (NullReferenceException)
			{ // if the client does not have a card(card == null) then it will be displayed a message
				Console.WriteLine($"Sorry, but {client.FullName} does not have a card and there is no need to show information about him/her! \n");
			}
		}
	}
}
