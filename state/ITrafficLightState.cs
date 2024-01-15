using System.Threading.Tasks;
using state;

public interface ITrafficLightState
{
    Task ExecuteAsync(TrafficLight trafficLight);
}