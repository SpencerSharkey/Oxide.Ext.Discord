﻿namespace Oxide.Ext.Discord.DiscordEvents
{
    using Oxide.Ext.Discord.DiscordObjects;

    public class GuildMemberRemove
    {
        public string guild_id { get; set; }

        public User user { get; set; }
    }
}
