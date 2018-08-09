using Microsoft.Bot.Connector;
using MovieBot.Commands;
using MovieBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace MovieBot
{
    public class BotService
    {
        private readonly List<ICommand> commands;

        public BotService()
        {
            commands = new List<ICommand>();

            var baseIntefaceType = typeof(ICommand);
            var botCommands = Assembly.GetAssembly(baseIntefaceType)
                .GetTypes()
                .Where(types=>types.IsClass && !types.IsAbstract && types.GetInterface("ITool") != null);
            foreach(var botCommand in botCommands)
                commands.Add((ICommand)Activator.CreateInstance(botCommand));
        }

        public async Task<Activity> Run(Activity activity)
        {
            return activity;
        }
     }
}