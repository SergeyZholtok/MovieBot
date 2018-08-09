using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBot.Interfaces
{
    interface ICommand
    {
        string Description { get; set; }
        List<String> CommandName { get; set; }
        Activity Run(Activity activity);
    }
}
