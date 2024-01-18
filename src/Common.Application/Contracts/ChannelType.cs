
namespace Common.Application.Contracts
{
    /// <summary>
    /// Discord channel types from DSharpPlus
    /// </summary>
    public enum ChannelType
    {
        //
        // Summary:
        //     Indicates that this is a text channel.
        Text = 0,
        //
        // Summary:
        //     Indicates that this is a private channel.
        Private = 1,
        //
        // Summary:
        //     Indicates that this is a voice channel.
        Voice = 2,
        //
        // Summary:
        //     Indicates that this is a group direct message channel.
        Group = 3,
        //
        // Summary:
        //     Indicates that this is a channel category.
        Category = 4,
        //
        // Summary:
        //     Indicates that this is a news channel.
        News = 5,
        //
        // Summary:
        //     Indicates that this is a store channel.
        [Obsolete("Store channels have been sunset.", true)]
        Store = 6,
        //
        // Summary:
        //     Indicates that this is a thread within a news channel.
        NewsThread = 10,
        //
        // Summary:
        //     Indicates that this is a public thread within a channel.
        PublicThread = 11,
        //
        // Summary:
        //     Indicates that this is a private thread within a channel.
        PrivateThread = 12,
        //
        // Summary:
        //     Indicates that this is a stage channel.
        Stage = 13,
        //
        // Summary:
        //     Indicates that this is a directory channel.
        Directory = 14,
        //
        // Summary:
        //     Indicates that this is a forum channel.
        GuildForum = 15,
        //
        // Summary:
        //     Indicates unknown channel type.
        Unknown = int.MaxValue
    }
}
