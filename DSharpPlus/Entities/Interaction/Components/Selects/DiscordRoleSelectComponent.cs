namespace DSharpPlus.Entities;

public sealed class DiscordRoleSelectComponent : BaseDiscordSelectComponent
{
    /// <summary>
    /// Enables this component.
    /// </summary>
    /// <returns>The current component.</returns>
    public DiscordRoleSelectComponent Enable()
    {
        this.Disabled = false;
        return this;
    }
    /// <summary>
    /// Disables this component.
    /// </summary>
    /// <returns>The current component.</returns>
    public DiscordRoleSelectComponent Disable()
    {
        this.Disabled = true;
        return this;
    }

    internal DiscordRoleSelectComponent() => this.Type = ComponentType.RoleSelect;

    /// <summary>
    /// Creates a new role select component.
    /// </summary>
    /// <param name="customId">The ID of this component.</param>
    /// <param name="placeholder">Placeholder text that's shown when no options are selected.</param>
    /// <param name="disabled">Whether this component is disabled.</param>
    /// <param name="minOptions">The minimum amount of options to be selected.</param>
    /// <param name="maxOptions">The maximum amount of options to be selected, up to 25.</param>
    public DiscordRoleSelectComponent(string customId, string placeholder, bool disabled = false, int minOptions = 1, int maxOptions = 1) : this()
    {
        this.CustomId = customId;
        this.Placeholder = placeholder;
        this.Disabled = disabled;
        this.MinimumSelectedValues = minOptions;
        this.MaximumSelectedValues = maxOptions;
    }
}
