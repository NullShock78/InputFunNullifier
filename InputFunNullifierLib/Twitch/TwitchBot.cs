using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib;
using TwitchLib.Api;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Models;
using TwitchLib.Communication.Clients;

namespace InputFunNullifier.Twitch
{
    //TODO: FIX CONNECTION CLOSE/RECONNECT BUGS
    static class TwitchBot
    {
        static TwitchClient client = null;
        static WebSocketClient customClient = null;
        public static bool Connected { get; private set; } = false;
        static string channelToWatch = null;

        public static bool AllowBotOutput { get; set; } = true;
        //public static void Initialize(GameManager manager)
        //{
        //    gameManager = manager;
        //}

        public static void Connect(string channelUsername, string botusername, string oauth)
        {
            //Connected = true;
            channelToWatch = channelUsername;
            if (client == null)
            {
                ConnectionCredentials credentials = new ConnectionCredentials(botusername, oauth);
                //ConnectionCredentials credentials = new ConnectionCredentials()
                var clientOptions = new ClientOptions
                {
                    MessagesAllowedInPeriod = 750,
                    ThrottlingPeriod = TimeSpan.FromSeconds(30),
                };
                customClient = new WebSocketClient(clientOptions);
                client = new TwitchClient(customClient);
                client.Initialize(credentials);
                
                //client.OnSendReceiveData += Client_OnSendReceiveData;
                client.OnChatCommandReceived += Client_OnChatCommandReceived;
                client.OnMessageReceived += Client_OnMessageReceived;
                client.OnJoinedChannel += Client_OnJoinedChannel;
                client.OnConnected += Client_OnConnected;
                
                //client.OnConnectionError += Client_OnConnectionError;
                //client.OnDisconnected += Client_OnDisconnected;
                //TODO: add "helper" list
                //client.OnWhisperCommandReceived += Client_OnWhisperCommandReceived;
                client.Connect();
            }
            else
            {
                Connected = true;
                try
                {
                    client.JoinChannel(channelToWatch);
                    SendMessage("Connected");
                }
                catch
                {
                    Connected = false;
                }
            }
        }

        private static void Client_OnSendReceiveData(object sender, TwitchLib.Client.Events.OnSendReceiveDataArgs e)
        {
            Console.WriteLine("RAW DATA:");
            Console.WriteLine(e.Data);
            Console.WriteLine("====================================================");
        }

        private static void Client_OnDisconnected(object sender, TwitchLib.Communication.Events.OnDisconnectedEventArgs e)
        {
            int i = 0;
        }

        static List<string> testArgList = new List<string>();

        //[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private static void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            var msg = e.ChatMessage.Message;

            //string cmd = null;
            Console.WriteLine("OnMessageRecieved:");
            Console.WriteLine(msg);
            Console.WriteLine($"UserName {e.ChatMessage.Username}");
            Console.WriteLine($"User Type {e.ChatMessage.UserType}");
            Console.WriteLine($"Reward: {e.ChatMessage.CustomRewardId}");
            Console.WriteLine($"Bits: {e.ChatMessage.Bits}");
            Console.WriteLine("====================================================");

            //if (msg.Contains("LUL"))
            //{
            //    cmd = "test5";
            //}
            //else if (msg.Contains("KEK"))
            //{
            //    cmd = "test6";
            //}
            //else if (msg.Contains("Pog"))
            //{
            //    cmd = "test7";
            //}

            //if (cmd != null)
            //{
            //    ChatCommand command = new ChatCommand(e.ChatMessage, "vote", cmd, testArgList, '!');
            //    //TODO: HANDLE COMMAND
            //    TwitchManager.HandleCommand(command);
            //}
        }

        //private void Client_OnWhisperCommandReceived(object sender, TwitchLib.Client.Events.OnWhisperCommandReceivedArgs e)
        //{
        //    gameManager.HandleWhisperModeratorCommands(e.Command);
        //}

        public static void Disconnect()
        {
            Console.WriteLine("Left Channel");
            Connected = false;
            client?.LeaveChannel(channelToWatch);
            client = null;
        }

        public static void SilentDisconnect()
        {
            Connected = false;
        }

        private static void Client_OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            Console.WriteLine($"Joined {e.Channel}");
        }

        private static void Client_OnConnected(object sender, TwitchLib.Client.Events.OnConnectedArgs e)
        {
            Connected = true;
            client.JoinChannel(channelToWatch);
            Console.WriteLine("Connected");
        }

        private static void Client_OnChatCommandReceived(object sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
        {
            Console.WriteLine("OnCommandRecieved:");
            Console.WriteLine($"[{e.Command.CommandText}] : {e.Command.ArgumentsAsString}");
            Console.WriteLine("====================================================");
            TwitchManager.HandleCommand(e.Command);
        }

        //[MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public static void SendMessage(string message)
        {
            if (Connected && AllowBotOutput)
            {
                //Commented out for testing reasons
                client?.SendMessage(channelToWatch, "/me " + message);
            }
        }


    }
}
