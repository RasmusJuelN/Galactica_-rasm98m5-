
namespace Galactica__rasm98m5_
{
    internal abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Positioning { get; set; }
        public StarType StarType { get; set; }


        public class Position
        {
            public int x { get; set; }
            public int y { get; set; }
            public override string ToString()
            {
                return ($"{x} {y}");
            }
        }
    }
    public enum StarType { YellowDwarf = 1, White, BlueNeutron, RedGiant }
}
