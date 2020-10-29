using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketStore
{
    public class MarketStore
    {
        private List<Client> _clients = new List<Client>();

        public MarketStore() { }

        public void AddClientToTheMarketStore(Client client)
        {
            if (this._clients.Any(c => c == client))
            { // if there is repeated addition of a client it will show a message and break the whole method
                Console.WriteLine($"There is already existing client with name {client.FullName}! \n");

                return;
            }
            else
            { // if there is no repeated addition of a client, the client will be added to the market store
                this._clients.Add(client);
                client.PrintCardDetailsForClient();
            }
        }

        public void RemoveClientFromTheMarketStore(Client client)
        {
            if (this._clients.Any(c => c == client))
            { // if there is a matching client then it will be removed and break thw whole method
                this._clients.Remove(client);
                Console.WriteLine($"Client with name {client.FullName} is successfully removed!\n");

                return;
            }
            else
            { // if not it will be displayed a message and the client won't be removed
                Console.WriteLine($"There is no matching client with the name of {client.FullName} to remove from the market!\n");
            }
        }
    }
}
