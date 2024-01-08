using static Assets.Enumerations;

namespace Assets.BicycleComponents.BicycleFrames
{
    public abstract class AbstractMainFrame :IMainFrame
    {
        public string ModelName { get; set; }
        public int ProductionYear { get; set; }
        public string SerialNumber { get; set; }
        public BicycleGeometryTypes Geometry { get; set; }
        public BicyclePaintColorTypes PaintColor { get; set; }
        public BicycleSuspensionTypes SuspensionType { get; set; }
        public ManufacturingStatusTypes ManufacturingStatus { get; set; }

        protected AbstractMainFrame()
        {
            ModelName = string.Empty;
            SerialNumber = Guid.NewGuid().ToString();
            ProductionYear = DateTime.Now.Year;
            ManufacturingStatus = ManufacturingStatusTypes.Specified;
        }

        public void Build()
        {
            Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
            ManufacturingStatus = ManufacturingStatusTypes.FrameManufactured;
            PrintBuildStatus();

            Console.WriteLine($"Painting the frame {PaintColor.ToString()}");
            ManufacturingStatus = ManufacturingStatusTypes.Painted;
            PrintBuildStatus();

            if (SuspensionType != BicycleSuspensionTypes.Hardtail)
            {
                Console.WriteLine($"Mounting the {SuspensionType.ToString()} suspension.");
                ManufacturingStatus = ManufacturingStatusTypes.SuspensionMounted;
                PrintBuildStatus();
            }

            Console.WriteLine("{0} {1} Bicycle serial number {2} manufacturing complete!",
                ProductionYear, ModelName, SerialNumber);
            ManufacturingStatus = ManufacturingStatusTypes.Complete;
            PrintBuildStatus();
        }

        private void PrintBuildStatus()
        {
            Console.WriteLine($"Status: {ManufacturingStatus.ToString()}");
        }

        public override string ToString()
        {
            return
                $"Your bicycle is a {PaintColor.ToString()} {ModelName}, with a {SuspensionType.ToString()} suspension and a(n) {Geometry.ToString()} geometry.";
        }
    }
}
