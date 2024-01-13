using System.Threading.Tasks;
using state;

public interface ITrafficLightState
{
    Task ChangeAsync(TrafficLight trafficLight);
}