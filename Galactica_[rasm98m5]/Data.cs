namespace Galactica__rasm98m5_
{
    internal class Data
    {
        public Data()
        {
            WelcomeToGalactica();
        }

        public void WelcomeToGalactica()
        {
            Star Sun = new();
            {
                Sun.Id = 1;
                Sun.Name = "Sun";
                Sun.Type = StarType.YellowDwarf;
                Sun.Temperature = 91823;
            }

            Planet Mercury = new Planet();
            {
                Mercury.Id = 1;
                Mercury.Name = "Mercury";
                Mercury.DiameterMeter = 4879400;
                Mercury.RotationPeriodHours = 1407.5;
                Mercury.RevolutionPeriodDays = 88;
                Mercury.Type = PlanetType.Terrestial;
                Mercury.Positioning = new SpaceObjects.Position() { x = 45, y = 332 };
            }

            Planet Venus = new Planet();
            {
                Venus.Id = 2;
                Venus.Name = "Venus";
                Venus.DiameterMeter = 6754238;
                Venus.RotationPeriodHours = 49.2;
                Venus.RevolutionPeriodDays = 288;
                Venus.Type = PlanetType.Terrestial;
                Venus.Positioning = new SpaceObjects.Position() { x = 12, y = 97 };
            }

            Planet Earth = new Planet();
            {
                Earth.Id = 3;
                Earth.Name = "Earth";
                Earth.DiameterMeter = 8712344;
                Earth.RotationPeriodHours = 24;
                Earth.RevolutionPeriodDays = 365;
                Earth.Type = PlanetType.Terrestial;
                Earth.Positioning = new SpaceObjects.Position() { x = 15, y = 23 };
            }

            Planet Mars = new Planet();
            {
                Mars.Id = 4;
                Mars.Name = "Mars";
                Mars.DiameterMeter = 3405005;
                Mars.RotationPeriodHours = 55.2;
                Mars.RevolutionPeriodDays = 411;
                Mars.Type = PlanetType.Terrestial;
                Mars.Positioning = new SpaceObjects.Position() { x = 29, y = 95 };
            }

            Planet Jupiter = new Planet();
            {
                Jupiter.Id = 5;
                Jupiter.Name = "Jupiter";
                Jupiter.DiameterMeter = 3478354;
                Jupiter.RotationPeriodHours = 81.9;
                Jupiter.RevolutionPeriodDays = 644;
                Jupiter.Type = PlanetType.Gas_Giant;
                Jupiter.Positioning = new SpaceObjects.Position() { x = 76, y = 42 };
            }

            Planet Saturn = new Planet();
            {
                Saturn.Id = 6;
                Saturn.Name = "Saturn";
                Saturn.DiameterMeter = 7895685;
                Saturn.RotationPeriodHours = 16;
                Saturn.RevolutionPeriodDays = 821;
                Saturn.Type = PlanetType.Gas_Giant;
                Saturn.Positioning = new SpaceObjects.Position() { x = 93, y = 12 };
            }

            Planet Uranus = new Planet();
            {
                Uranus.Id = 7;
                Uranus.Name = "Uranus";
                Uranus.DiameterMeter = 19292923;
                Uranus.RotationPeriodHours = 41.8;
                Uranus.RevolutionPeriodDays = 911;
                Uranus.Type = PlanetType.Gas_Giant;
                Uranus.Positioning = new SpaceObjects.Position() { x = 11, y = 84 };
            }

            Planet Neptune = new Planet();
            {
                Neptune.Id = 8;
                Neptune.Name = "Neptune";
                Neptune.DiameterMeter = 77889787;
                Neptune.RotationPeriodHours = 12.8;
                Neptune.RevolutionPeriodDays = 4001;
                Neptune.Type = PlanetType.Giant;
                Neptune.Positioning = new SpaceObjects.Position() { x = 18, y = 36 };
            }



            Moon Luna = new Moon();
            {
                Luna.Id = 1;
                Luna.Name = "Luna";
                Luna.DiameterMeter = 1232145688;
                Luna.RotationPeriodHours = 123;
                Luna.RevolutionPeriodDays = 1112;
                Luna.Orbiting = Earth;
                Luna.Positioning = (new SpaceObjects.Position() { x = 21, y = 24 });
            }
            Moon Titan = new Moon();
            {
                Titan.Id = 2;
                Titan.Name = "Titan";
                Titan.DiameterMeter = 5456544;
                Titan.RotationPeriodHours = 432;
                Titan.RevolutionPeriodDays = 54;
                Titan.Orbiting = Earth;
                Titan.Positioning = (new SpaceObjects.Position() { x = 2, y = 99 });
            }
            Moon Phobos = new Moon();
            {
                Phobos.Id = 3;
                Phobos.Name = "Phobos";
                Phobos.DiameterMeter = 5678567;
                Phobos.RotationPeriodHours = 554;
                Phobos.RevolutionPeriodDays = 867;
                Phobos.Orbiting = Mars;
                Phobos.Positioning = (new SpaceObjects.Position() { x = 14, y = 12 });
            }
            Moon Europa = new Moon();
            {
                Europa.Id = 4;
                Europa.Name = "Europe";
                Europa.DiameterMeter = 1453415;
                Europa.RotationPeriodHours = 23;
                Europa.RevolutionPeriodDays = 566;
                Europa.Orbiting = Jupiter;
                Europa.Positioning = (new SpaceObjects.Position() { x = 41, y = 14 });
            }
            Moon Deimos = new Moon();
            {
                Deimos.Id = 5;
                Deimos.Name = "Deimos";
                Deimos.DiameterMeter = 1345145;
                Deimos.RotationPeriodHours = 234;
                Deimos.RevolutionPeriodDays = 34;
                Deimos.Orbiting = Mars;
                Deimos.Positioning = (new SpaceObjects.Position() { x = 22, y = 96 });
            }
            Moon Ganymedes = new Moon();
            {
                Ganymedes.Id = 6;
                Ganymedes.Name = "Ganymedes";
                Ganymedes.DiameterMeter = 12341234;
                Ganymedes.RotationPeriodHours = 78;
                Ganymedes.RevolutionPeriodDays = 765;
                Ganymedes.Orbiting = Jupiter;
                Ganymedes.Positioning = (new SpaceObjects.Position() { x = 92, y = 81 });
            }
            Moon Io = new Moon();
            {
                Io.Id = 7;
                Io.Name = "Io";
                Io.DiameterMeter = 75675;
                Io.RotationPeriodHours = 456;
                Io.RevolutionPeriodDays = 87654;
                Io.Orbiting = Jupiter;
                Io.Positioning = (new SpaceObjects.Position() { x = 12, y = 41 });
            }
            Moon Mimas = new Moon();
            {
                Mimas.Id = 8;
                Mimas.Name = "Mimas";
                Mimas.DiameterMeter = 8678676;
                Mimas.RotationPeriodHours = 121;
                Mimas.RevolutionPeriodDays = 26;
                Mimas.Orbiting = Saturn;
                Mimas.Positioning = (new SpaceObjects.Position() { x = 15, y = 78 });
            }

            Sun.Planets.Add(Mercury);
            Sun.Planets.Add(Venus);
            Sun.Planets.Add(Earth);
            Sun.Planets.Add(Mars);
            Sun.Planets.Add(Jupiter);
            Sun.Planets.Add(Saturn);
            Sun.Planets.Add(Uranus);
            Sun.Planets.Add(Neptune);

            Earth.Moon.Add(Luna);
            Mars.Moon.Add(Phobos);
            Mars.Moon.Add(Deimos);
            Jupiter.Moon.Add(Titan);
            Jupiter.Moon.Add(Ganymedes);
            Jupiter.Moon.Add(Io);
            Jupiter.Moon.Add(Europa);
            Saturn.Moon.Add(Mimas);


            foreach (var planet in Sun.Planets)
            {

                Console.WriteLine($"\nPlant name: { planet.Name}\nPlanet Type: {planet.Type}\nDistance to sun: {planet.Distance(Sun, planet)} units");

                Console.WriteLine("Moons:");
                foreach (var moon in planet.Moon)
                {

                    Console.WriteLine($"{moon.Name} - distance to planet: {moon.Distance(moon, planet)} units");

                }

            }



        }


    }
}
