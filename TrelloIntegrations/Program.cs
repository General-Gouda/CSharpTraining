using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manatee.Trello;
using Manatee.Trello.ManateeJson;
using Manatee.Trello.WebApi;

namespace TrelloIntegrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new ManateeSerializer();
            TrelloConfiguration.Serializer = serializer;
            TrelloConfiguration.Deserializer = serializer;
            TrelloConfiguration.JsonFactory = new ManateeFactory();
            TrelloConfiguration.RestClientProvider = new WebApiClientProvider();
            TrelloAuthorization.Default.AppKey = "key";
            TrelloAuthorization.Default.UserToken = "token";

            var organization = new Organization("organizationID");

            foreach (var board in organization.Boards)
            {
                string boardName = board.Name;

                //if (boardName == "PowerShellTestBoard")
                //{
                    string boardID = board.Id;
                    var boardInfo = new Board(boardID);
                    var boardCards = boardInfo.Cards;
                    var boardMembers = boardInfo.Members;
                    var boardLists = boardInfo.Lists;

                    Console.WriteLine("Board Name: {0}\nBoard ID: {1}\n",boardName,boardID);

                    foreach (var list in boardLists)
                    {
                        Console.WriteLine("    Cards in list '{0}':", list.Name);

                        foreach (var card in list.Cards)
                        {
                            Console.WriteLine("        - {0}", card.Name);
                            if (string.IsNullOrWhiteSpace(card.Description) != true)
                                Console.WriteLine("           Description: {0}", card.Description);
                        }
                        Console.WriteLine("\n");
                    }
                //}
            }

            Console.ReadLine();
        }
    }
}
