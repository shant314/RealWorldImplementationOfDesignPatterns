using AbstractMethodPattern;
using Assets.BicycleComponents.BicycleFrames;
using BuilderPattern;
using DecoratorPattern;
using FacadePattern;
using FactoryMethodPattern;
using NoPattern;
using ObjectPoolPattern;
using SimpleFactoryPattern;
using SingletonPattern;
using System.Numerics;



Console.WriteLine("Hello, World!");

//NoPatternTest();

//SimpleFactoryPatternTest();
//FactoryMethodPatternTest();
//AbstactFactoryPatternTest();
//BuilderPatternTest();
//ObjectPoolPatternTest();
//SingletonPatternTest();

//DecoratorPatternTest();
FacadePatternTest();

#region NoPattern
void NoPatternTest()
{
    const string errorText = "You must pass in mountainBicycle, cruiser, recumbent, or roadBicycle";
    var bicycleType = Console.ReadLine()?.Trim().ToLower();
    if (!string.IsNullOrEmpty(bicycleType))
    {
        new BuildBicycle(bicycleType);
    }
    else
    {
        Console.WriteLine(errorText);
    }
}

#endregion NoPattern

#region Creational Patterns

void SimpleFactoryPatternTest()
{
    const string errorText = "You must pass in mountainBicycle, cruiser, recumbent, or roadBicycle";
    var bicycleType = Console.ReadLine()?.Trim().ToLower();
    if (!string.IsNullOrEmpty(bicycleType))
    {
        SimpleFactoryBicycle bicycleFactory = new SimpleFactoryBicycle();
        var bicycle = bicycleFactory.CreateBicycle(bicycleType);
        bicycle.Build();
    }
    else
    {
        Console.WriteLine(errorText);
    }
}

void FactoryMethodPatternTest()
{
    var dallasBicycleFactory = new DallasCreator();
    var dallasBicycle = dallasBicycleFactory.CreateProduct("HILLCREST");
    dallasBicycle.Build();

    var alpineBicycleFactory = new AlpineCreator();
    var alpineBicycle = alpineBicycleFactory.CreateProduct("PALO DURO CANYON RANGER");
    alpineBicycle.Build();
}

void AbstactFactoryPatternTest()
{
    /*The key here is the use of the interface as the factory type. 
    Coding this way makes it possible to change the factory without relying on concrete 
    factory classes directly.*/
    IBicycleFactory roadBicycleFactory = new RoadBicycleFactory();
    IMainFrame bicycleFrame = roadBicycleFactory.CreateBicycleFrame();
    var bicycleHandlebar = roadBicycleFactory.CreateBicycleHandlebar();
    Console.WriteLine("We just made a road Bicycle!");
    Console.WriteLine(bicycleFrame.ToString());
    Console.WriteLine(bicycleHandlebar.ToString());

    IBicycleFactory mountainBicycleFactory = new MountainBicycleFactory();
    bicycleFrame = mountainBicycleFactory.CreateBicycleFrame();
    bicycleHandlebar = mountainBicycleFactory.CreateBicycleHandlebar();
    Console.WriteLine("We just made a mountain Bicycle!");
    Console.WriteLine(bicycleFrame.ToString());
    Console.WriteLine(bicycleHandlebar.ToString());

}

void BuilderPatternTest()
{
    var roadBicycleBuilder = new RoadBicycleBuilder();
    var director = new Director(roadBicycleBuilder);
    var roadBicycle = director.Make();
    Console.WriteLine(roadBicycle.ToString());

    var mountainBicycleBuilder = new MountainBicycleBuilder();
    director.ChangeBuilder(mountainBicycleBuilder);
    var mountainBicycle = director.Make();
    Console.WriteLine(mountainBicycle.ToString());
}

void ObjectPoolPatternTest()
{
    Console.WriteLine("Here's a program that controls some welding robots from a pool of 10.");
    var robotArmPool = new WeldingArmPool
    {
        MaxSize = 10
    };

    var arm01 = robotArmPool.GetArmFromPool();
    arm01.MoveToStation(1);
    if (arm01.DoWeld())
        robotArmPool.ReturnArmToPool(arm01);

    Console.WriteLine("There are " + robotArmPool.ArmsAvailableCount + " arms available");
    // what if we tried to use too many?
    // here we throw a hard error because there are
    // literally no more arms in the real world.
    // most object pools would go ahead and create
    // a new object instead and return that.

    for (int i = 0; i < 11; i++)
    {
        try
        {
            var arm = robotArmPool.GetArmFromPool();
            arm.MoveToStation(i + 1);
            arm.DoWeld();

            Console.WriteLine("There are " + robotArmPool.ArmsAvailableCount + " arms available");
            // fail to send it back so we run out of arms
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

void SingletonPatternTest()
{

    Console.WriteLine("Here's a program that controls some welding robots from a pool of 10");
    Console.WriteLine(
        "This one uses a singleton version of the object pool making it impossible to instantiate more than once.");

    // note the new keyword doesn't work by design.  uncomment the following line if you don't believe me.
    // var armPoolSingleton = new WeldingArmPoolSingleton();

    // instead you need the static instance property.  it's getter handles the singleton instance for you.
    var weldingArmPoolSingleton = WeldingArmPoolSingleton.Instance;
    var arm01 = weldingArmPoolSingleton.GetArmFromPool();
    arm01.MoveToStation(1);
    if (arm01.DoWeld())
        weldingArmPoolSingleton.ReturnArmToPool(arm01);

    Console.WriteLine("There are " + weldingArmPoolSingleton.ArmsAvailableCount + " arms available");

    // now try it again.  it's pointing to the same single instance.  if it weren't there would be 10.

    var armPoolSingleton2 = WeldingArmPoolSingleton.Instance;
    Console.WriteLine("There are " + armPoolSingleton2.ArmsAvailableCount + " arms available");
}


#endregion Creational Patterns

#region Structural Patterns

void DecoratorPatternTest()
{
    // no decorator
    var regularRoadBicycle = new Assets.RoadBicycle();
    regularRoadBicycle.Build();

    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

    var manualPrinterForBicycle = new ManualPrinter();
    var documentedBicycle = new DocumentedBicycle(regularRoadBicycle, manualPrinterForBicycle);
    documentedBicycle.Build();

    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

    var manufacturingInventoryNotifier = new MaterialsInventoryNotifier();
    var notifiedBicycle = new NotifiedBicycle(regularRoadBicycle, manufacturingInventoryNotifier);
    notifiedBicycle.Build();

    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

    var notifiedAndPrintedBicycle = new NotifiedBicycle(
        new DocumentedBicycle(regularRoadBicycle, manualPrinterForBicycle), manufacturingInventoryNotifier);
    notifiedAndPrintedBicycle.Build();

    /*You can also use a decorator to extend classes that are awkward or impossible to extend through 
    regular inheritance. Consider a class that is sealed, meaning it can’t be extended through inheritance. 
    You can still extend it using a decorator*/

}

void FacadePatternTest()
{
    const int numberOfAssemblyStations = 20;
    const float consistentY = 52.0f;
    const float consistentZ = 128.0f;
    const float consistentW = 90.0f;
    var assemblyStations = new Quaternion[numberOfAssemblyStations];

    /*Since the assembly line is literally a straight line, it is easy to evenly space the stations 25 feet apart 
    along the line’s X axis. A simple loop can then pre-populate the array of quaternions that represent 
    the workstations on the assembly line:*/
    for (int i = 0; i< numberOfAssemblyStations; i++)
    {
        var xPosition = i * 25.0f;
        assemblyStations[i] = new Quaternion(xPosition, consistentY, consistentZ, consistentW);
    }

    Console.WriteLine("RobotArm 0: Robotic arm control system activated!");
    var robotArm0 = new RobotArmFacade(new WelderAttachmentApi(), new BufferAttachmentApi(), new GrabberAttachementApi());

    Console.WriteLine("Initializing welder function in arm 0");
    robotArm0.CurrentAttachment = Assets.Enumerations.RobotArmAttachmentTypes.Welder;//set the attachment to a welder
    robotArm0.MoveTo(assemblyStations[0]);
    robotArm0.Actuate();

    Console.WriteLine("Initializing buffer function in arm 0");
    robotArm0.CurrentAttachment = Assets.Enumerations.RobotArmAttachmentTypes.Buffer;
    robotArm0.MoveTo(assemblyStations[3]);
    robotArm0.Actuate();

    Console.WriteLine("Initializing grabber function in arm 0");
    robotArm0.CurrentAttachment = Assets.Enumerations.RobotArmAttachmentTypes.Grabber;
    robotArm0.MoveTo(assemblyStations[7]);
    robotArm0.Actuate();

    // we can have list of robot arms facade in a loop to keep on operationg.

    /*we needed to deal with three different APIs from three different vendors to work with three 
    different pieces of hardware. By using the Façade pattern, we were able to deal with one common 
    interface for all three APIs, which isolates the bulk of our code from changes made in the API. When 
    the API changes, we may need to change the façade, but we won’t need to change anything else*/
}

#endregion Structural Patterns