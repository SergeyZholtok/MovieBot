using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using TMDbLib;
using TMDbLib.Client;

namespace MovieBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        
        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
            {
            var activity = await result as Activity;

            TMDbClient client = new TMDbClient("b7290a98a01bc42d6c1ec6a8cb92a0c0");

            if(activity?.Text != null)
            {
                var service = new BotService();
                var replyConversation = service.Run(activity);
                await context.PostAsync(replyConversation.Result.Text);
            }
        
            context.Wait(MessageReceivedAsync);
        }
    }
}