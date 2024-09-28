namespace LIN.Notes.Shared.Modals;

public partial class DeleteModal
{


    [Parameter]
    public string Content { get; set; }


    /// <summary>
    /// Acción al presionar sobre el botón de editar.
    /// </summary>
    [Parameter]
    public Action OnAccept { get; set; } = () => { };


    [Parameter]
    public Action OnCancel { get; set; } = () => { };



    /// <summary>
    /// Key.
    /// </summary>
    private string Key { get; init; } = Guid.NewGuid().ToString();




    /// <summary>
    /// Abrir el modal.
    /// </summary>
    public void Show()
    {
        _ = InvokeAsync(() =>
        {
            StateHasChanged();
            Js.InvokeVoidAsync("showModal", $"popup-modal-{Key}", DotNetObjectReference.Create(this), $"btn-accept-{Key}", $"btn-cancel-{Key}", $"btn-close-{Key}");

        });

    }


}