using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /*we could skip this part because all of our bicycles fit the same interface. A director can create 
    anything, given a builder. The director’s job is to call the methods in the builder according to any 
    business logic required and to return the product created by the builder.
    The point of the director is to run the build methods in the builder in the right order*/
    public class Director
    {
        private IBicycleBuilder _builder;

        public Director(IBicycleBuilder builder)
        {
            _builder = builder;
        }

        /*method that allows us to change the builder without exposing it directly*/
        public void ChangeBuilder(IBicycleBuilder builder)
        {
            _builder = builder;
        }

        /*Make method’s job to run the build steps in the right order, the oreder is the same for any builder*/
        public IBicycleProduct Make()
        {
            _builder.BuildFrame();
            _builder.BuildHandlebars();
            _builder.BuildSeat();
            _builder.BuildSuspension();
            _builder.BuildDrivetrain();
            _builder.BuildBrakes();

            return _builder.GetProduct();
        }
    }
}
