using Assets;

namespace DecoratorPattern
{
    public class NotifiedBicycle :AbstractBicycleDecorator
    {
        private readonly INotifier _notifier;

        public NotifiedBicycle(IBicycle bicycle, INotifier notifier) : base(bicycle)
        {
            _notifier = notifier;
        }

        public override void Build()
        {
            base._undecoratedBicycle.Build();
            _notifier.Notify();
        }
    }
}
