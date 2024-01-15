using AbstractMethodPattern;
using Assets;
using Assets.BicycleComponents.BicycleFrames;
using Assets.PaintableBicycle;
using Assets.PaintableBicycle.PaintJobs;
using BuilderPattern;
using CommandPattern;
using CompositePattern;
using DecoratorPattern;
using FacadePattern;
using FactoryMethodPattern;
using IteratorPattern;
using NoPattern;
using ObjectPoolPattern;
using ObserverPattern;
using SimpleFactoryPattern;
using SingletonPattern;
using System.Net.Mail;
using System.Numerics;


Console.WriteLine("This project will display sample outputs for design patterns, just type a design pattern you want to test for example Simple factory.");

switch (Console.ReadLine()!.ToUpper())
{
    case "SIMPLEFACTORY":
    case "SIMPLE FACTORY":
    case "SIMPLE":
        SimpleFactoryPatternTest();
        break;
    case "FACTORYMETHOD":
    case "FACTORY METHOD":
    case "FACTORY":
        FactoryMethodPatternTest();
        break;
    case "ABSTRACTFACTORY":
    case "ABSTRACT FACTORY":
    case "ABSTRACT":
        AbstractFactoryPatternTest();
        break;
    case "BUILDERPATTERN":
    case "BUILDER PATTERN":
    case "BUILDER":
        BuilderPatternTest();
        break;
    case "ObjectPool":
    case "Object Pool":
    case "Object":
        ObjectPoolPatternTest();
        break;
    case "SINGLETONPATTERN":
    case "SINGLETON PATTERN":
    case "SINGLETON":
        SingletonPatternTest();
        break;
    case "DECORATORPATTERN":
    case "DECORATOR PATTERN":
    case "DECORATOR":
        DecoratorPatternTest();
        break;
    case "FACADEPATTERN":
    case "FACADE PATTERN":
    case "FACADE":
        FacadePatternTest();
        break;
    case "COMPOSITEPATTERN":
    case "COMPOSITE PATTERN":
    case "COMPOSITE":
        CompositePatternTest();
        break;
    case "BRIDGEPATTERN":
    case "BRIDGE PATTERN":
    case "BRIDGE":
        BridgePatternTest();
        break;
    case "COMMANDPATTERN":
    case "COMMAND PATTERN":
    case "COMMAND":
        CommandPatternTest();
        break;
    case "ITERATORPATTERN":
    case "ITERATOR PATTERN":
    case "ITERATOR":
        IteratorPatternTest();
        break;
    case "OBSERVERPATTERN":
    case "OBSERVER PATTERN":
    case "OBSERVER":
        ObserverPatternTest();
        break;
    case null:
    default:
        Console.WriteLine("Running no pattern.");
        NoPatternTest();
        break;


}

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

void AbstractFactoryPatternTest()
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
    for (int i = 0; i < numberOfAssemblyStations; i++)
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

void CompositePatternTest()
{
    Console.WriteLine("Composite Example");

    // for this exercise, a crankset is comprised of the bottom bracket, two chain rings, the crank arms and pedals
    // I think it's easiest to go bottom up starting with the leaves.

    var leftPedal = new Pedal(234.14f, 11.32f);
    var rightPedal = new Pedal(234.14f, 11.32f);

    // the pedals connect to the crank arm
    var crankArm = new CrankArm(432.93f, 34.32f);
    crankArm.SubBicycleComponents.Add(leftPedal);
    crankArm.SubBicycleComponents.Add(rightPedal);

    // the crank arm connects to the large chain ring
    // the large chain ring has a small chain ring attached
    var largeChainRing = new LargeChainRing(57.0983f, 13.53f);
    var smallChainRing = new SmallChainRing(52.57f, 11.33f);

    largeChainRing.SubBicycleComponents.Add(smallChainRing);
    largeChainRing.SubBicycleComponents.Add(crankArm);

    // the large chain ring connects to the shaft
    var shaft = new Shaft(82.03f, 19.55f);
    shaft.SubBicycleComponents.Add(largeChainRing);

    // finally, the shaft threads through the bottom bracket to form a system called the crank set.
    var bottomBracket = new BottomBracket(284.834f, 11.51f);
    bottomBracket.SubBicycleComponents.Add(shaft);

    var crankSet = new CrankSet(0f, 0f);  // I used 0's because the crank set is the sum of its parts
    crankSet.SubBicycleComponents.Add(bottomBracket);

    Console.WriteLine(" ------------------------ Weights --------------------------");
    crankSet.DisplayWeight();

    Console.WriteLine(" ------------------------ Cost --------------------------");
    crankSet.DisplayCost();
    /*The composite pattern allows you to work with complex tree structures elegantly by allowing you to 
    make full use of recursion and polymorphism. Just be careful that you work with classes that have 
    a very common interface. You might be introducing code smell if you must shoe-horn a bunch of 
    classes that don’t really fit together. This pattern pairs nicely with the Builder pattern already in use 
    because the builder can be made to assemble the tree structure.*/

    /*The Composite pattern is used whenever you need to process a hierarchical structure as a tree. The 
    main requirement for the pattern to be effective is that every node in the tree must conform to a 
    common interface. If that can be managed, you can use this pattern to process the tree in any manner 
    you might need. You can add new class types to your tree, so long as they conform to the common 
    interface. Using this pattern, you can create novel processing capabilities while honoring the openclosed principle. Recursion and polymorphism can be exploited to expedite your processing.*/
}

void BridgePatternTest()
{
    // Our original mountain bike was black.  We can still do that.
    var blackPaintJob = new BlackPaintJob();
    var standardBlackMountainBicycle = new PaintableMountainBicycle(blackPaintJob);
    standardBlackMountainBicycle.Build();

    // For our kickstarter backers, we have the exclusive Mountain Bike with the Amarillo Peacock paint job!
    var amarilloPeacockPaintjob = new AmarilloPeacockPaintJob();
    var customPaintedMountainBike = new PaintableMountainBicycle(amarilloPeacockPaintjob);
    customPaintedMountainBike.Build();
}


#endregion Structural Patterns

#region Behavioral Patterns

void CommandPatternTest()
{
    var blackPaintJob = new BlackPaintJob();
    var standardMountainBicycle = new PaintableMountainBicycle(blackPaintJob);
    // prepare the robot arm with different attachment api.
    var robotArmFacade = new RobotArmFacade(new WelderAttachmentApi(), new BufferAttachmentApi(), new GrabberAttachementApi());
    var command = new BuildFrameCommand(new AssemblyLineCommandReceiver(robotArmFacade), standardMountainBicycle);
    //command.Execute(); not good design to do here.

    var commandSender = new CommandSender(command);
    commandSender.ExecuteCommand();
}

void IteratorPatternTest()
{
    var bicycleOrders = new BicycleOrderCollection();
    var dealership = new Customer
    {
        FirstName = "John",
        LastName = "Galt",
        CompanyName = "Atlas Cycling",
        EmailAddress = new MailAddress("johngalt@whois.com"),
        ShippingAddress = "123 Singleton Drive",
        ShippingCity = "Dallas",
        ShippingState = "Tx",
        ShippingZipCode = "75248"
    };

    var amarilloPeacockPaintjob = new AmarilloPeacockPaintJob();
    var bicycle0 = new PaintableMountainBicycle(amarilloPeacockPaintjob);

    var order0 = new BicycleOrder(dealership, bicycle0);
    //bicycleOrders.Orders.Add(order0);
    bicycleOrders.AddOrder(order0);

    var turquoisePaintJob = new BluePaintJob();
    var bicycle1 = new PaintableCruiserBicycle(turquoisePaintJob);
    var order1 = new BicycleOrder(dealership, bicycle1);
    bicycleOrders.AddOrder(order1);

    var whitePaintJob = new WhitePaintJob();
    var bicycle2 = new PaintableRoadBicycle(whitePaintJob);
    var order2 = new BicycleOrder(dealership, bicycle2);
    bicycleOrders.AddOrder(order2);

    var bicycle3 = new PaintableRecumbentBicycle(amarilloPeacockPaintjob);
    var order3 = new BicycleOrder(dealership, bicycle3);
    bicycleOrders.AddOrder(order3);

    var redPaintJob = new RedPaintJob();
    var bicycle4 = new PaintableRoadBicycle(redPaintJob);
    var order4 = new BicycleOrder(dealership, bicycle4);
    bicycleOrders.AddOrder(order4);

    // to iterate, just use the normal syntax you use for generic iterators
    foreach (BicycleOrder order in bicycleOrders)
    {
        Console.WriteLine(order.Bicycle.PaintJob.Name);
    }
}

void ObserverPatternTest()
{
    // declare a subject that can be observed.
    var logisticsSubject = new LogisticsSubject();

    // declare an observer.
    var exFedObserver = new ExFedObserver();
    //add observer.
    logisticsSubject.Attach(exFedObserver);

    // Now let's make some bikes.  Each time we have 10, we'll send a notification.
    var pickupOrder = new List<AbstractBicycle>();

    // start form one. 
    for (var i = 1; i < 100; i++)
    {
        var mountainBicycle = new MountainBicycle();

        Thread.Sleep(500);
        Console.WriteLine(mountainBicycle.ToString());

        pickupOrder.Add(mountainBicycle);

        if (i % 10 == 0)
            logisticsSubject.NotifyPickupAvailable();
    }

    pickupOrder.Clear();

    /*you can create other observer that will ship custom color bicycles, and instead of counting bicycles count color spacific ones.*/
}

#endregion Behavioral Patterns



/*
    The Decorator pattern allows us to extend existing classes by decorating or wrapping new functionality 
around the original class. The decorators can stack as a Russian Matryoshka doll does, where one doll 
is nested inside another.
 
    Façade pattern, which allows us to abstract and insulate our software from 
complex dependencies. The pattern allows you to put a simple face on a complex API by uniformly 
exposing operations, even if they aren’t uniform under the covers. You can also use a façade to only 
expose the elements in a complex API or structure that are important to your implementations. If in 
the future, the third-party API changes significantly, you can replace the façade without having tightly 
coupled API calls sprinkled throughout your code.
 
    Composite pattern, any time you need to deal with a tree structured (group sets in a tree-like structure)
this pattern allow us to user recursion over sub elements.

    Bridge pattern
The main objective of the Bridge pattern is to allow two complex object structures to be developed and 
maintained independently of one another. 

    Command pattern
You can use the Command pattern any time you have logic to perform an action and you want to 
isolate it from tightly coupling to anything that may want to call that logic.
 */