using System.Threading.Tasks;

namespace state;

public class TrafficLight(ITrafficLightState state)
{
    public ITrafficLightState State { get; set; } = state;

    public Task ChangeAsync => State.ExecuteAsync(this);
}
