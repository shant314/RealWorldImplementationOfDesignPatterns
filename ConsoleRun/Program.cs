using AbstractMethodPattern;
using Assets.BicycleComponents.BicycleFrames;
using BuilderPattern;
using FactoryMethodPattern;
using NoPattern;
using ObjectPoolPattern;
using SimpleFactoryPattern;
using SingletonPattern;



Console.WriteLine("Hello, World!");

//NoPatternTest();
//SimpleFactoryPatternTest();
//FactoryMethodPatternTest();
//AbstactFactoryPatternTest();
//BuilderPatternTest();
//ObjectPoolPatternTest();
SingletonPatternTest();


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

#region SimpleFactoryPattern

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

#endregion SimpleFactoryPattern

#region FactoryMethodPattern
void FactoryMethodPatternTest()
{
    var dallasBicycleFactory = new DallasCreator();
    var dallasBicycle = dallasBicycleFactory.CreateProduct("HILLCREST");
    dallasBicycle.Build();

    var alpineBicycleFactory = new AlpineCreator();
    var alpineBicycle = alpineBicycleFactory.CreateProduct("PALO DURO CANYON RANGER");
    alpineBicycle.Build();
}
#endregion FactoryMethodPattern

#region AbstactFactoryPattern

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

#endregion AbstarctFactoryPattern

#region BuilderPattern
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

#endregion BuilderPattern

#region ObjectPoolPattern
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
#endregion ObjectPoolPattern

#region SingletonPattern
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

#endregion SingletonPattern