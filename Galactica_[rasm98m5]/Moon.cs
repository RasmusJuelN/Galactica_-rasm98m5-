

namespace Galactica__rasm98m5_
{
    internal sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public double Distance(Moon moon, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow(moon.Positioning.x - planet.Positioning.x, 2) + Math.Pow(moon.Positioning.y - planet.Positioning.y, 2));
            return Math.Round(distance, 2);
        }
    }
}
