using System.Collections.Generic;

namespace Discord
{
    /// <summary>
    ///     Represents the data sent with the <see cref="IComponentInteraction"/>.
    /// </summary>
    public interface IComponentInteractionData : IDiscordInteractionData
    {
        /// <summary>
        ///     Gets the components Custom Id that was clicked.
        /// </summary>
        string CustomId { get; }

        /// <summary>
        ///     Gets the type of the component clicked.
        /// </summary>
        ComponentType Type { get; }

        /// <summary>
        ///     Gets the value(s) of a <see cref="SelectMenuComponent"/> interaction response.
        /// </summary>
        IReadOnlyCollection<string> Values { get; }
    }
}
