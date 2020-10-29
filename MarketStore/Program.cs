using System;

namespace MarketStore
{
	public class Program
	{
		public static void Main(string[] args)
		{
			MarketStore marketStore = new MarketStore();

			// bronze cards
			Card bronzeCard = new Card(200, 50, CardTypes.Bronze);
			Card bronzeCardDiscount = new Card(500, 200, CardTypes.Bronze);
			Card secondBronzeCardDiscount = new Card(1000, 350, CardTypes.Bronze);

			// silver cards
			Card silverCard = new Card(100, 250, CardTypes.Silver);
			Card secondSilverCard = new Card(300, 500, CardTypes.Silver);

			// clients with bronze cards
			Client bronzeCardClient = new Client("John", "Johnson", bronzeCard);
			Client secondBronzeCardClient = new Client("Oliver", "Murphy", bronzeCardDiscount);
			Client thirdBronzeCardClient = new Client("Sophie", "Williams", secondBronzeCardDiscount);

			// clients with silver cards
			Client silverCardClient = new Client("Michael", "Jordan", silverCard);
			Client secondSilverCardClient = new Client("Emily", "Brown");
			secondSilverCardClient.AddCard(secondSilverCard);

			// clients with gold cards
			Client goldCardClient = new Client("Noah", "Smith", new Card(1500, 1300, CardTypes.Gold));
			Client secondGoldCardClient = new Client("Jessica", "Jones", new Card(1000, 200, CardTypes.Gold));

			// clients with no cards
			Client noCardClient = new Client("Jake", "Jackson");
			Client secondNoCardClient = new Client("Ava", "Jones");

			// adding clients to the market store
			marketStore.AddClientToTheMarketStore(bronzeCardClient);
			marketStore.AddClientToTheMarketStore(secondBronzeCardClient);
			marketStore.AddClientToTheMarketStore(thirdBronzeCardClient);
			marketStore.AddClientToTheMarketStore(silverCardClient);
			marketStore.AddClientToTheMarketStore(secondSilverCardClient);
			marketStore.AddClientToTheMarketStore(goldCardClient);
			marketStore.AddClientToTheMarketStore(noCardClient);
			marketStore.AddClientToTheMarketStore(goldCardClient);
			marketStore.AddClientToTheMarketStore(secondGoldCardClient);
			marketStore.AddClientToTheMarketStore(secondNoCardClient);

			marketStore.RemoveClientFromTheMarketStore(secondNoCardClient);
			marketStore.RemoveClientFromTheMarketStore(secondNoCardClient);
			


			Console.ReadKey();
		}
	}
}
