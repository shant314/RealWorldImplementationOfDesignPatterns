
namespace StrategyPattern
{
    public interface INavigationStrategy
    {
        public INavigationRoute FindRoute(string parameters);
    }
}
