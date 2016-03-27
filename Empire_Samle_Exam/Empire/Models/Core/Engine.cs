using System;
using System.Linq;
using System.Text;
using Empire.Models.Core.Buildings;
using Empire.Models.Interfaces;

namespace Empire.Models.Core
{
    public class Engine: IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;
        private IData data;
        private IOutputWriter writer;
        private IInputReader reader;

        public Engine(IBuildingFactory buildingFactory, IUnitFactory unitFactory, IResourceFactory resourceFactory, IData data, IOutputWriter writer, IInputReader reader)
        {
            this.BuildingFactory = buildingFactory;
            this.UnitFactory = unitFactory;
            this.ResourceFactory = resourceFactory;
            this.Data = data;
            this.Writer = writer;
            this.Reader = reader;
        }

        public IInputReader Reader
        {
            get
            {
                return this.reader;
            }
            set {
                if (value==null)
                {
                    throw new ArgumentNullException("Input Reader cannot be null.");
                }
                this.reader = value;
            }
        }

        public IOutputWriter Writer
        {
            get
            {
                return this.writer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Output Writer cannot be null.");
                }
                this.writer = value;
            }
        }

        public IData Data
        {
            get
            {
                return this.data;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Data cannot be null.");
                }
                this.data = value;
            }
        }

        public IBuildingFactory BuildingFactory
        {
            get
            {
                return this.buildingFactory;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Building Factory cannot be null.");
                }
                this.buildingFactory = value;
            }
        }

        public IUnitFactory UnitFactory
        {
            get
            {
                return this.unitFactory;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Unit Factory cannot be null.");
                }
                this.unitFactory = value;
            }
        }

        public IResourceFactory ResourceFactory
        {
            get
            {
                return this.resourceFactory;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Resource Factory cannot be null.");
                }
                this.resourceFactory = value;
            }
        }


        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildingCounter();
            }
        }

        private void UpdateBuildingCounter()
        {
            foreach (var building in this.Data.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.Data.Resources[resource.ResourceType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.Data.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, this.unitFactory,
                this.resourceFactory);
            //((Building)building).OnResourceProduced += this.AddResource;
            //((Building)building).OnUnitProduced += this.AddUnit;
            this.Data.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            AppendTreasuryInfo(output);
            AppendBuildingsInfo(output);

            AppendUnitsInfo(output);

            this.writer.Print(output.ToString().Trim());
        }

        private void AppendUnitsInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.Data.Units.Any())
            {
                foreach (var unit in this.Data.Units)
                {
                    output.AppendLine(string.Format("--{0}: {1}", unit.Key, unit.Value));
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendBuildingsInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.Data.Buildings.Any())
            {
                foreach (var building in this.Data.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendTreasuryInfo(StringBuilder output)
        {
            output.AppendLine("Treasury:");
            foreach (var resource in this.Data.Resources)
            {
                output.AppendLine(string.Format("--{0}: {1}", resource.Key, resource.Value));
            }
        }

        //private void AddResource(object sender, ResourceProducedEventArgs e)
        //{
        //    var resource = e.Resource;
        //    this.Data.Resources[resource.ResourceType] += resource.Quantity;
        //}

        //private void AddUnit(object sender, UnitProducedEventArgs e)
        //{
        //    var unit = e.Unit;
        //    this.Data.AddUnit(unit);
        //}
    }
}
