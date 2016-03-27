namespace Empire
{
    using Empire.Models.Core.Factories;
    using Empire.Models.Core;
    using Empire.Models.Core.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Data();

            var engine = new Engine(buildingFactory, unitFactory, resourceFactory, data, writer, reader);
            engine.Run();

        }
    }
}
