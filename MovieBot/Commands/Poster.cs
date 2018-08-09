using Microsoft.Bot.Connector;
using MovieBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBot.Commands
{
    public class Poster : ICommand
    {
        public Poster()
        {
            CommandName = new List<string>() { "/Афиша" };
            Description = "Узнать о фильмах, которые идут сейчас в кинотеатрах или скоро выйдут.";
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