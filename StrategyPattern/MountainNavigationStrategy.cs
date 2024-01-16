namespace StrategyPattern
{
    public class MountainNavigationStrategy : INavigationStrategy
    {
        public INavigationRoute FindRoute(string parameters)
        {
            // This is where your amazing algorithm goes.  But since this is a book on patterns and not algorithms...
            return new NavigationRoute
            {
                Details = "I'm a mountain route."
            };
        }
    }
}
