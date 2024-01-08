using Assets;

namespace DecoratorPattern
{

    public class DocumentedBicycle : AbstractBicycleDecorator
    {
        private readonly IDocumenter _documenter;

        public DocumentedBicycle(IBicycle bicyle, IDocumenter documenter) : base(bicyle)
        {
            _documenter = documenter;
        }

        /*Here’s the actual decoration. The Build() method that exists on any object passed into the constructor 
        is called. Then, the additional decorating behavior – in this case calling the PrintManual()
        method on the decoration – is called*/
        public override void Build()
        {
            base._undecoratedBicycle.Build();
            _documenter.PrintManual();
        }
    }
}
/*We can implement this class in various ways, 
 first, we can have the documenter logic in the class itself by implementing the IDocumentor interface here, this will make the class a single purpose.
 second, pass in a concrete object of a documenter (ManualPrinter) in the constructor, or the interface that it implements (IDocumentor), that is what we did here.*/