using CounterStrikeSharp.API.Core;
namespace MapChooserAPI;

public interface IWasdMenu
{
    public string Title { get; set; }
    public LinkedList<IWasdMenuOption>? Options { get; set; }
    // previous option node
    public LinkedListNode<IWasdMenuOption>? Prev { get; set; }
    public LinkedListNode<IWasdMenuOption> Add(string display, Action<CCSPlayerController, IWasdMenuOption> onChoice, string? key = null);
    public bool RetractVote(int? index = null, string? key = null);
}