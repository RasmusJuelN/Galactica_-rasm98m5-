
namespace Galactica__rasm98m5_
{
    internal class Star : SpaceObjects
    {
        public StarType Type { get; set; }
        public int Temperature { get; set; }

        public List<Planet> Planets = new();

        public Star()
        {
            Positioning = new Position();
        }
    }
    enum PlanetType { Terrestial = 1, Giant, Dwarf, Gas_Giant }
}




