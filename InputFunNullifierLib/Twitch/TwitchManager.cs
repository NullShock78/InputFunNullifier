using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;

namespace InputFunNullifier.Twitch
{
    public static class TwitchManager
    {
        static List<TwitchRule> rules = new List<TwitchRule>();

        public static void AddRule(TwitchRule rule)
        {
            rules.Add(rule);
        }

        public static void HandleCommand(ChatCommand command)
        {
            var rule = rules.FirstOrDefault(x => x.Settings.Command == command.CommandText);
            if (rule != null)
            {
                rule.DoRule(command);
            }
        }

        public static void Connect(string channelToWatch, string botUser, string oauth)
        {
            TwitchBot.Connect(channelToWatch, botUser, oauth);
        }

        public static void Disconnect()
        {
            TwitchBot.Disconnect();
        }
    }
}
