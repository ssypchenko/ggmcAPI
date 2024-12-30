using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Capabilities;
using CounterStrikeSharp.API.Core.Plugin;
namespace MapChooserAPI;
public interface MCIAPI
{
    event Action CanVoteEvent;
    public bool GGMC_IsVoteInProgress();
    public void UpdateMapWeights(Dictionary<string, int> newWeights);
}