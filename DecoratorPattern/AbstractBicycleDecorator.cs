
using Assets;
using static Assets.Enumerations;

namespace DecoratorPattern
{
    public abstract class AbstractBicycleDecorator : IBicycle
    {
        //The protected field to hold the original IBicyle object is crucial here. This is the original, undecorated object instance we’ll be decorating:
        private protected readonly IBicycle _undecoratedBicycle;

        //By providing protected constructor, you can limit your class to be instantiated only by its subclasses.
        protected AbstractBicycleDecorator(IBicycle bicycle)
        {
            _undecoratedBicycle = bicycle;
        }

        public string ModelName { get => _undecoratedBicycle.ModelName; set => _undecoratedBicycle.ModelName = value; }
        public int ProductionYear { get => _undecoratedBicycle.ProductionYear; }
        public string SerialNumber { get => _undecoratedBicycle.SerialNumber; }
        public BicycleGeometryTypes Geometry { get => _undecoratedBicycle.Geometry; set => _undecoratedBicycle.Geometry = value; }
        public BicyclePaintColorTypes PaintColor { get => _undecoratedBicycle.PaintColor; set => _undecoratedBicycle.PaintColor = value; }
        public BicycleSuspensionTypes SuspensionType { get => _undecoratedBicycle.SuspensionType; set => _undecoratedBicycle.SuspensionType = value; }
        public BicycleManufacturingStatusTypes ManufacturingStatus { get => _undecoratedBicycle.ManufacturingStatus; set => _undecoratedBicycle.ManufacturingStatus = value; }

        public abstract void Build();
    }
}

/*There are thre seteps involved in decorating a class:
1. Create a class with a private member containing the class you want to decorate. In our case, 
    we’ll be decorating the AbstractBicycle class. We need a class that contains a private
    property of the IBicycle type, and a constructor that allows us to set this property.
2. We need to implement all the properties and methods that are already in the IBicycle
    interface. When we implement the getter, setter, and regular methods for the decorator, we 
    pass them through to the private instance. In effect, we’ve wrapped the class and the decorator 
    performs exactly as in the original class.
3. We add the decorating properties and methods. If you intend to stack your decorators, it is 
    important to have a common method that can link them together. We’ll be using the Build()
    method.*/