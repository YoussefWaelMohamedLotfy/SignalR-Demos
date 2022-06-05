using Microsoft.AspNetCore.SignalR;

namespace SignalRDemos.Hubs;

public class DeathlyHallowsHub : Hub
{
    public Dictionary<string, int> GetRaceStatus()
    {
        return SD.DeathlyHallowRace;
    }
}
