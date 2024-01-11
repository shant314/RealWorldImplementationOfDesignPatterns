using Assets.PaintableBicycle;
using FacadePattern;
using System.Numerics;
using static Assets.Enumerations;

namespace CommandPattern
{
    // we can also make this class an abstract, if we have other executing business models. for the sampel here we ony have this one.
    // this class is simply asking for who will execute the operation, and on what subject it will be with what commands.

    public class AssemblyLineCommandReceiver
    {
        private readonly RobotArmFacade _robotArmFacade;// ths is the answer for the firs part of the question, the robot arm will execute the operation.
        private const int _numberOfAssemblyStations = 20;
        private const float _consistentY = 52.0f;
        private const float _consistentZ = 128.0f;
        private const float _consistentW = 90.0f;
        private readonly Quaternion[] _assemblyStations; //array of assembly station points.

        // get the subject that will execute the command.
        public AssemblyLineCommandReceiver(RobotArmFacade robotArmFacade)
        {
            // get the subject and later prepare it to serve commands.
            _robotArmFacade = robotArmFacade;
            _assemblyStations = new Quaternion[_numberOfAssemblyStations];

            for (var i = 0; i < _numberOfAssemblyStations; i++)
            {
                var xPosition = i * 25.0f;
                _assemblyStations[i] = new Quaternion(xPosition, _consistentY, _consistentZ, _consistentW);
            }
        }

        // ths is the answer for the second part of the question, a bicycle will be the subject, and the commands are listed in here!.
        public void ExecuteBusinessLogicOnSubject(IPaintableBicycle bicycle)
        {
            // Now let's follow an abbreviated imaginary assembly of a bicycle frame by controlling a robot arm.

            //first attach the grabber to robot arm.
            _robotArmFacade.CurrentAttachment = RobotArmAttachmentTypes.Grabber;
            // now move the arm to first position, where it will grab the bicycle.
            _robotArmFacade.MoveTo(_assemblyStations[0]);
            // perform the grabbing operation.
            _robotArmFacade.Actuate();
            // brig it to next station, where it will be welded.
            _robotArmFacade.MoveTo(_assemblyStations[1]);

            // Once the body is moved to welding location, we change the attachment to welder.
            _robotArmFacade.CurrentAttachment = RobotArmAttachmentTypes.Welder;
            // here the arm is welding parts.
            _robotArmFacade.Actuate();

            // Now grab the frame and move it to station 4 for painting.  My choice of station 4 is arbitrary.
            _robotArmFacade.CurrentAttachment = RobotArmAttachmentTypes.Grabber;
            // perform the grabbing operation.
            _robotArmFacade.Actuate();
            // brig it to next station, where it will be painted.
            _robotArmFacade.MoveTo(_assemblyStations[4]);
            // now, painting.
            bicycle.PaintJob.ApplyPrimer();
            bicycle.PaintJob.ApplyPaint();
            bicycle.PaintJob.ApplyTopCoat();

            // Finally move the painted frame to station 6 for buffing and polishing.
            // we still have our grabber attached, so use it to relocation.
            _robotArmFacade.MoveTo(_assemblyStations[6]);

            // shining time.
            _robotArmFacade.CurrentAttachment = RobotArmAttachmentTypes.Buffer;
            // make it shiny.
            _robotArmFacade.Actuate();
        }

    }
}
