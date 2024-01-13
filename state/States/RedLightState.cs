using System;
using System.Threading.Tasks;

namespace state;

public class RedLightState : ITrafficLightState
{
    public async Task ChangeAsync(TrafficLight trafficLight)
    {
        Console.WriteLine("Red Light");
        await Task.Delay(TimeSpan.FromSeconds(4));
        trafficLight.State = new GreenLightState();
    }
}
