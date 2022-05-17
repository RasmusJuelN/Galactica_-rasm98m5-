namespace Galactica__rasm98m5_
{
    internal class Planet : SpaceObjects

    {
        public double DiameterMeter { get; set; }
        public double RotationPeriodHours { get; set; }
        public double RevolutionPeriodDays { get; set; }
        public PlanetType Type { get; set; }

        public List<Moon> Moon = new();


        public double Distance(Star star, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow(star.Positioning.x - planet.Positioning.x, 2) + Math.Pow(star.Positioning.y - planet.Positioning.y, 2));
            return Math.Round(distance, 2); ;
        }

    }

}

