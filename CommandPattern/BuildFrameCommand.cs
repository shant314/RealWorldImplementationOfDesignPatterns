using Assets.PaintableBicycle;

namespace CommandPattern
{
    // we can have other build commands, here we are building the frame.
    public class BuildFrameCommand : ICommand
    {
        //command related information. NOTE, this also can be an abstract definition as I stated in the class definition.
        private AssemblyLineCommandReceiver _assemblyLineCommandReceiver;
        //subject to execute command on.
        private IPaintableBicycle _paintableBicycle;

        public BuildFrameCommand(AssemblyLineCommandReceiver assemblyLineCommandReceiver, IPaintableBicycle paintableBicycle)
        {
            _assemblyLineCommandReceiver = assemblyLineCommandReceiver;
            _paintableBicycle = paintableBicycle;
        }

        public void Execute()
        {
            //run the business logic contained within the receiver
            _assemblyLineCommandReceiver.ExecuteBusinessLogicOnSubject(_paintableBicycle);
        }
    }
}
