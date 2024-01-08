namespace BuilderPattern
{
    /*IBicycleBuilder interface defines what must be in a builder class, 
    which will define the various builders for the bicycle lines*/
    public interface IBicycleBuilder
    {
        public void Reset();
        public void BuildFrame();
        public void BuildHandlebars();
        public void BuildSeat();
        public void BuildSuspension();
        public void BuildDrivetrain();
        public void BuildBrakes();

        public IBicycleProduct GetProduct();
    }
}
