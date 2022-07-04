using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;

namespace InputFunNullifier.Twitch
{

    public static class TRS
    {
        public static Dictionary<string, TwitchRuleSettings> Settings = new Dictionary<string, TwitchRuleSettings>();
        //public static TwitchRuleSetting this[string id]
        //{
        //    get
        //    {
        //        return Settings[id];
        //    }
        //}

        //TODO: load twitch rule settings
    }

    /// <summary>
    /// Twitch settings
    /// </summary>
    [Serializable]
    public class TwitchRuleSettings
    {
        public bool Enabled { get; set; } = true;
        public string ID { get; set; }
        public string Command { get; set; }
        public int BitsMinimum { get; set; } = 0;
        public float Cooldown { get; set; } = 0f;
    }

    public class TwitchRule
    {
        public string ID { get; set; }
        public TwitchRuleSettings Settings { get; private set; }

        public int BitsMinimum => Settings.BitsMinimum;
        public float CurrentCooldown { get; set; } = 0f;

        public static string LuaCode { get; set; } = null;
        Action<ChatCommand> commandAction = null;

        public bool Enabled { get { return Settings.Enabled; } set { Settings.Enabled = value; } }

        public virtual void DoRule(ChatCommand command) 
        {
            //By default do lua
            if(commandAction != null)
            {
                commandAction.Invoke(command);
            }
            if (!string.IsNullOrEmpty(LuaCode))
            {
                //TODO: add lua
            }
        }

        public TwitchRule(string id)
        {
            ID = id;
            if (!TRS.Settings.ContainsKey(id)) TRS.Settings.Add(ID, new TwitchRuleSettings());
            Settings = TRS.Settings[ID];
        }

        public TwitchRule(string id, string luaCode)
        {
            ID = id;
            if (!TRS.Settings.ContainsKey(id)) TRS.Settings.Add(ID, new TwitchRuleSettings());
            Settings = TRS.Settings[ID];
            LuaCode = luaCode;
        }

        public TwitchRule(string id, Action<ChatCommand> commandActionToDo)
        {
            ID = id;
            if (!TRS.Settings.ContainsKey(id)) TRS.Settings.Add(ID, new TwitchRuleSettings());
            Settings = TRS.Settings[ID];
            LuaCode = null;
            this.commandAction = commandActionToDo;
        }

    }
}
