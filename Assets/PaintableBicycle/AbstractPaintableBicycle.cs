using static Assets.Enumerations;

namespace Assets.PaintableBicycle
{
    public class AbstractPaintableBicycle : IPaintableBicycle
    {
        public string ModelName { get; set; }
        public int ProductionYear { get; set; }
        public string SerialNumber { get; set; }
        public BicycleGeometryTypes Geometry { get; set; }
        public BicycleSuspensionTypes SuspensionType { get; set; }
        public BicycleManufacturingStatusTypes ManufacturingStatus { get; set; }
        public IPaintJob PaintJob { get; set; }

        private protected AbstractPaintableBicycle(IPaintJob paintJob)
        {
            ModelName = string.Empty; // will be filled in subclass constructor
            SerialNumber = Guid.NewGuid().ToString();
            ProductionYear = DateTime.Now.Year;
            ManufacturingStatus = BicycleManufacturingStatusTypes.Specified;
            PaintJob = paintJob;
        }

        public void Build()
        {
            Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
            ManufacturingStatus = BicycleManufacturingStatusTypes.FrameManufactured;
            PrintBuildStatus();

            Console.WriteLine($"Painting the frame {PaintJob.Name}");
            PaintJob.ApplyPrimer();
            PaintJob.ApplyPaint();
            PaintJob.ApplyTopCoat();
            ManufacturingStatus = BicycleManufacturingStatusTypes.Painted;
            PrintBuildStatus();

            if (SuspensionType != BicycleSuspensionTypes.Hardtail)
            {
                Console.WriteLine($"Mounting the {SuspensionType.ToString()} suspension.");
                ManufacturingStatus = BicycleManufacturingStatusTypes.SuspensionMounted;
                PrintBuildStatus();
            }

            Console.WriteLine("{0} {1} Bicycle serial number {2} manufacturing complete!", ProductionYear, ModelName, SerialNumber);
            ManufacturingStatus = BicycleManufacturingStatusTypes.Complete;
            PrintBuildStatus();
        }

        private void PrintBuildStatus()
        {
            Console.WriteLine($"Status: {ManufacturingStatus.ToString()}");
        }

        public override string ToString()
        {
            return
                $"Your bicycle is a {PaintJob.Name} {ModelName}, with a {SuspensionType.ToString()} suspension and a(n) {Geometry.ToString()} geometry.";
        }
    }
}
/*We have four bicycle concrete types to represent, and for that we are using this abstract class.*/