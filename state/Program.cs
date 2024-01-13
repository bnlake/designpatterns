using state;

var light = new TrafficLight(new RedLightState());

do
{
    await light.ChangeAsync();
} while (true);