namespace LumexUI.Docs.Client.Components;

public partial class Header
{
    private readonly IEnumerable<(string Link, string Name)> _navigationItems = [
        new("docs/overview", "Docs"),
        new("docs/components", "Components"),
    ];

    private readonly NavbarSlots _navbarClasses = new()
    {
        Wrapper = "py-5 gap-6"
    };
}
