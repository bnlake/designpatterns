using System;
using System.Threading.Tasks;

namespace state;

public class YellowLightState : ITrafficLightState
{
    public async Task ChangeAsync(TrafficLight trafficLight)
    {
        Console.WriteLine("Yellow Light");
        await Task.Delay(TimeSpan.FromSeconds(2));
        trafficLight.State = new RedLightState();
    }
}
