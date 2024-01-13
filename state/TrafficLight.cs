using System.Threading.Tasks;

namespace state;

public class TrafficLight
{
    public ITrafficLightState State;
    public TrafficLight(ITrafficLightState State)
    {
        this.State = State;
    }

    public Task ChangeAsync()
    {
        return State.ChangeAsync(this);
    }
}
