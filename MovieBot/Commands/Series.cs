using Microsoft.Bot.Connector;
using MovieBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBot.Commands
{
    public class Series : ICommand
    {
        public Series()
        {
            CommandName = new List<string>() { "/Сериалы" };
            Description = "Выбор сериала.";
        }

        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> CommandName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Activity Run(Activity activity)
        {
            if (activity != null && activity.Conversation != null)
                activity.Text = "Work!";
            return activity;
        }
    }
}