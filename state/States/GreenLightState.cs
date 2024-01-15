using System;
using System.Threading.Tasks;

namespace state;

public class GreenLightState : ITrafficLightState
{
    public async Task ExecuteAsync(TrafficLight trafficLight)
    {
        Console.WriteLine("Green Light");
        await Task.Delay(TimeSpan.FromSeconds(6));
        trafficLight.State = new YellowLightState();
    }
}
