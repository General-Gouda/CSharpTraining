using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackIntegrations
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlWithAccessToken = "https://hooks.slack.com/services/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";

            SlackClient client = new SlackClient(urlWithAccessToken);

            string dateTime = DateTime.Now.ToString();

            client.PostMessage(
                username: "Boaty McBoaterson",
                text: dateTime + "\nThis is a test message generated in C#!",
                color: SlackColors.slackColors(SlackColors.colors.Gray),
                pretext: "Testing!"
            );
        }
    }
}
