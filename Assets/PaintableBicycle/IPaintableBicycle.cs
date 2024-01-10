
namespace Assets.PaintableBicycle
{
    public interface IPaintableBicycle : ISimplifiedBicycle
    {
        IPaintJob PaintJob { get; set; }
    }
}
/*To handle our use case for the Bridge pattern, this interface that inherits from 
ISimplifiedBicycle. We’re doing it this way to maintain 
as much flexibility as we can*/