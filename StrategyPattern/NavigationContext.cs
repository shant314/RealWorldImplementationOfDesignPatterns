namespace StrategyPattern
{
    public class NavigationContext
    {
        //using an interface to be replaced with any of its implementations.
        public INavigationStrategy NavigationStrategy { get; set; }

        public NavigationContext()
        {
            //the default navigation is set to road.
            NavigationStrategy = new RoadNavigationStrategy();
        }

        public void StartNavigation()
        {
            // things happen here until eventually...
            var route = NavigationStrategy.FindRoute("parameters goe here");
            Console.WriteLine(route.Details);
        }
    }
}
