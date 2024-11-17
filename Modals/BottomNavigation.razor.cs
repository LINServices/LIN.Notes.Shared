namespace LIN.Notes.Shared.Modals;

public partial class BottomNavigation
{

    /// <summary>
    /// Sección actual de la barra de navegación.
    /// </summary>
    [Parameter]
    public DockSettings Settings { get; set; } = new();


    /// <summary>
    /// Elemento SVG del botón central.
    /// </summary>
    [Parameter]
    public Action? OnClick { get; set; }

    void Go()
    {
        OnClick?.Invoke();
    }

}

public class DockSettings
{

    public int Section { set; get; }
    public int DockIcon { set; get; }

    public Action OnCenterClick { get; set; } = () => { };

}